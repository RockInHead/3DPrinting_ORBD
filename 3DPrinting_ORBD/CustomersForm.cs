using System;
using System.Data;
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
            OkToolStripButton.Visible = false;
            customerBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void OkToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            OkToolStripButton.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
            {
                // Получаем текущую запись через BindingSource
                if (customerBindingSource.Current != null)
                {
                    DataRowView rowView = customerBindingSource.Current as DataRowView;
                    if (rowView != null && rowView.Row.Table.Columns.Contains("CustomerID"))
                    {
                        return Convert.ToInt32(rowView["CustomerID"]);
                    }
                }
            }

            return -1;
        }

        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            customerBindingSource.Position = customerBindingSource.Find("CustomerID", idCurrent);
        }
    }
}
