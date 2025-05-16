using System;
using System.Data;
using System.Windows.Forms;

namespace _3DPrinting_ORBD
{
    public partial class OrdersListForm : Form
    {
        public OrdersListForm()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void OrdersListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this._3D_PrintingDataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this._3D_PrintingDataSet.Customer);

        }

        private void OrdersListSaveItemToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.orderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении списка заказов!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        static OrdersListForm f;
        static public OrdersListForm olf
        {
            get
            {
                if (f == null || f.IsDisposed) f = new OrdersListForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void orderDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }





        private void CustomButton_Click(object sender, EventArgs e)
        {
            int id = -1;

            // Проверяем текущую запись и получаем код сотрудника
            if (orderBindingSource.Current is DataRowView currentRow)
            {
                try
                {
                    // Проверяем наличие столбца и что значение не DBNull и не пустое
                    if (currentRow.Row.Table.Columns.Contains("CustomerID")
                        && currentRow["CustomerID"] != DBNull.Value
                        && !string.IsNullOrEmpty(currentRow["CustomerID"].ToString()))
                    {
                        id = Convert.ToInt32(currentRow["CustomerID"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении кода сотрудника: {ex.Message}");
                }
            }

            // Показываем форму выбора
            if (CustomersForm.cf != null)
            {
                id = CustomersForm.cf.ShowSelectForm(id);
            }

            // Обновляем запись, если получен валидный ID
            if (id >= 0)
            {
                try
                {
                    if (orderBindingSource.Current is DataRowView rowToUpdate)
                    {
                        rowToUpdate["CustomerID"] = id;
                        orderBindingSource.EndEdit();
                        MessageBox.Show($"Установлен новый код сотрудника: {id}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении кода сотрудника: {ex.Message}");
                }
            }
        }
    }
}
