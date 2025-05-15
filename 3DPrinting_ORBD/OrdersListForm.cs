using System;
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
    }
}
