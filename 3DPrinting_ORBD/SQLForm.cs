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
    }
}
