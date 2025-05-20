using System;
using System.Data;
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

            try
            {
                // Сохраняем изменения (без Profit)
                this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

                // Перезагружаем данные, чтобы Profit пересчитался
                this.orderTableAdapter.Fill(this._3D_PrintingDataSet.Order);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        string GetSelectedFieldName()
        {
            return orderDataGridView.Columns[orderDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void FindToolStripButton_Click(object sender, EventArgs e)
        {
            if (FindToolStripTextBox.Text == "")
            {
                MessageBox.Show(
                    "Вы ничего не задали",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int indexPos;
            try
            {
                indexPos =
                    orderBindingSource.Find(
                        GetSelectedFieldName(),
                        FindToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
                orderBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show(
                    "Таких заказов нет",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                orderBindingSource.Position = 0;
            }
        }

        private void FindCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FindCheckBox.Checked)
            {
                if (FindToolStripTextBox.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        orderBindingSource.Filter =
                            GetSelectedFieldName() + "='" + FindToolStripTextBox.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                                        err.Message);
                    }
            }
            else
                orderBindingSource.Filter = "";
            if (orderBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                orderBindingSource.Filter = "";
                FindCheckBox.Checked = false;
            }

        }
    }
}
