using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;

namespace _3DPrinting_ORBD
{
    public partial class SQLForm : Form
    {
        public SQLForm()
        {
            InitializeComponent();
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных
            SqlConnection connection = new SqlConnection(Properties.Settings.Default._3D_PrintingConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonCustomers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Customer"); 
        }

        private void radioButtonOrders_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT OrderID, Profit AS [Текущая прибыль], 'Произойдет' AS Пояснение,
                                                            CAST(Cost+100-CostPrice AS decimal(16,2)) AS [Прибыль при повышении цены на 100] FROM [Order]");

        }

        private void radioButtonFinishedDetails_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT OrderID, Customer.CustomerID, FIO FROM [Order],
                                                              Customer WHERE [Order].CustomerID = Customer.CustomerID");
        }

        private static SQLForm sf;
        public static SQLForm sqlf
        {
            get
            {
                if (sf == null || sf.IsDisposed) sf = new SQLForm();
                return sf;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxOrderID.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\n Допустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }

            string sqlSelect = "";
            if (radioButtonDet_Sales.Checked)
                sqlSelect = @"SELECT 
                        c.CustomerID, 
                        o.OrderID,
                        c.FIO, 
                        SUM(o.Profit) AS Прибыль
                    FROM 
                        Customer c
                    INNER JOIN 
                        [Order] o ON c.CustomerID = o.CustomerID
                    WHERE 
                        c.FIO LIKE @FIO 
                    GROUP BY 
                        c.CustomerID,o.OrderID, c.FIO";
            else if (radioButtonDet_Type.Checked)
                sqlSelect = @"SELECT 
                            Customer.CustomerID,Customer.FIO,
                            Plastic AS [Тип пластика],
                            SUM(Profit) AS Прибыль  
                        FROM 
                            Customer 
                        INNER JOIN 
                            [Order] ON Customer.CustomerID = [Order].CustomerID
                        WHERE 
                            Customer.FIO LIKE @FIO 
                        GROUP BY 
                            Customer.CustomerID,Plastic, Customer.FIO";
            else
                sqlSelect = @"SELECT Customer.CustomerID,Customer.FIO,
	                            Profit AS Прибыль			
                            FROM Customer INNER JOIN [Order] ON
                            Customer.CustomerID=[Order].CustomerID
	                        WHERE 
                            Customer.FIO LIKE @FIO 
                            GROUP BY 
                                Customer.CustomerID,Customer.FIO, Profit";

            if (checkBoxMore.Checked)
                sqlSelect += " HAVING Sum(Profit) >@amount";
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Sum(Profit) desc";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default._3D_PrintingConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@FIO", textBoxOrderID.Text +
           "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                   Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text) && !radioButtonNoCorrelated.Checked)
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
            {
                
                sqlSelect = @"SELECT 
                            m.ModelID,
	                        m.FileFormat AS [Формат файла],
                            m.Dimensions AS [Размеры модели],
                            (
                                SELECT COUNT(*)
                                FROM FinishedDetail fd
                                WHERE fd.ModelID = m.ModelID -- Корреляция
                            ) AS [Напечатанные детали по модели]
                        FROM 
                            [3DModel] m
                        WHERE 
                            m.ModelID = @number;";
            }
            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"SELECT 
                            o.OrderID,
                            o.Profit
                        FROM 
                            [Order] o
                        WHERE 
                            o.Profit > (SELECT AVG(Profit) FROM [Order]);";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default._3D_PrintingConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                if (!radioButtonNoCorrelated.Checked)
                {
                    command.Parameters.Add("@number", SqlDbType.Int).Value = int.Parse(textBoxNumber.Text);
                }
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string fileImage = "";

        private void buttonOpenPhoto_model_Click(object sender, EventArgs e)
        {
            openFileDialogModel.Title = "Укажите файл для фото";
            if (openFileDialogModel.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogModel.FileName;
                try
                {
                    pictureBoxPhoto_model.Load(openFileDialogModel.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        void InsertModel()
        {
            if (String.IsNullOrEmpty(textBoxId_model.Text) ||
           (String.IsNullOrEmpty(textBoxOrderID_model.Text) ||
           (String.IsNullOrEmpty(textBoxDimension_model.Text))))
            {
                MessageBox.Show("Обязательно введите код блюда, название, тип и цену блюда", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            int id;
            if (!int.TryParse(textBoxId_model.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = 0;
            if (!int.TryParse(textBoxOrderID_model.Text, out orderId))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string sqlInsert = @"INSERT INTO [3DModel] (ModelID, OrderID, Dimensions,Sreenshot, FileFormat)
                 VALUES (@id, @orderId, @dimensions, @sreenshot, @fileFormat)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default._3D_PrintingConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@orderId", textBoxOrderID_model.Text);
            //или другим способом, если необходимо явное указание типа данных
            command.Parameters.Add("@dimensions", textBoxDimension_model.Text);
            command.Parameters.Add("@fileFormat", SqlDbType.NVarChar).Value = textBoxFileFormat_model.Text;

            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@sreenshot",
               File.ReadAllBytes(fileImage));
            else
            {
                command.Parameters.Add("@sreenshot", SqlDbType.VarBinary);
                command.Parameters["@sreenshot"].Value = DBNull.Value;
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectModels_Click(this, EventArgs.Empty);
        }

        private void buttonSelectModels_Click(object sender, EventArgs e)
        {
            dataGridViewModel.DataSource = FillDataGridView("SELECT * FROM [3DModel]");
            DataGridViewImageColumn column = (DataGridViewImageColumn)dataGridViewModel.Columns["Sreenshot"]; 
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        void UpdateModel()
        {
            if (String.IsNullOrEmpty(textBoxId_model.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда, для которого будете менять данные", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxId_model.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int orderId = 0;
            if ((!String.IsNullOrEmpty(textBoxOrderID_model.Text)) &&
           (!int.TryParse(textBoxOrderID_model.Text, out orderId)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string fileFormat = "";
            if ((String.IsNullOrEmpty(textBoxOrderID_model.Text)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE [3DModel] SET {0} WHERE ModelID = @id";
             SqlConnection connection = new
            SqlConnection(Properties.Settings.Default._3D_PrintingConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxId_model.Text))
                sqlValues += "ModelID=@id,";
            if (!String.IsNullOrEmpty(textBoxOrderID_model.Text))
                sqlValues += "OrderID=@orderId,";
            if (!String.IsNullOrEmpty(textBoxDimension_model.Text))
                sqlValues += "Dimensions=@dimensions,";
            if (!String.IsNullOrEmpty(textBoxFileFormat_model.Text))
                sqlValues += "FileFormat=@fileFormat,";
            if (!String.IsNullOrEmpty(fileImage))
                sqlValues += "Sreenshot=@screenshot";
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@screenshot",
               File.ReadAllBytes(fileImage));
            
            command.Parameters.AddWithValue("@id", id);
            if (!String.IsNullOrEmpty(textBoxOrderID_model.Text))
                command.Parameters.AddWithValue("@orderId", textBoxOrderID_model.Text);
            if (!String.IsNullOrEmpty(textBoxDimension_model.Text))
                command.Parameters.Add("@dimensions", textBoxDimension_model.Text);
            if (!String.IsNullOrEmpty(textBoxFileFormat_model.Text))
                command.Parameters.Add("@fileFormat", SqlDbType.NVarChar).Value = textBoxFileFormat_model.Text;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectModels_Click(this, EventArgs.Empty);
        }

        void DeleteModel()
        {
            if (String.IsNullOrEmpty(textBoxId_model.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            int id;
            if (!int.TryParse(textBoxId_model.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM [3DModel] WHERE ModelID=@Id";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default._3D_PrintingConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectModels_Click(this, EventArgs.Empty);
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_model.Checked)
            {
                InsertModel();
            }
            else if (radioButtonUpdate_model.Checked)
            {
                UpdateModel();
            }
            else if (radioButtonDelete_model.Checked)
            {
                DeleteModel();
            }
            else
            {
                MessageBox.Show("Вы не выбрали действие", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void radioButtonDelete_model_CheckedChanged(object sender, EventArgs e)
        {
            panelModel.Visible = !radioButtonDelete_model.Checked;

        }

        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonNoCorrelated_CheckedChanged(object sender, EventArgs e)
        {
            labelNumber.Visible = !radioButtonNoCorrelated.Checked;
            textBoxNumber.Visible = !radioButtonNoCorrelated.Checked;

        }

        private void radioButtonCorrelated_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonInsert_model_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxSelect_Enter(object sender, EventArgs e)
        {

        }
    }
}
