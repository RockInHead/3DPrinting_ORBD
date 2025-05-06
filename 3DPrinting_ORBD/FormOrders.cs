using System;
using System.Windows.Forms;

namespace _3DPrinting_ORBD
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this._3D_PrintingDataSet.Order);
        }

        private static FormOrders f;
        public static FormOrders of
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOrders();
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
