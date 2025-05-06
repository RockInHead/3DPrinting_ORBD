using System;
using System.Windows.Forms;

namespace _3DPrinting_ORBD
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this._3D_PrintingDataSet.Customer);

        }

        private static CustomersForm f;
        public static CustomersForm cf
        {
            get
            {
                if (f == null || f.IsDisposed) f = new CustomersForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
