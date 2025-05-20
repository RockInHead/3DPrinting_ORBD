using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPrinting_ORBD
{
    public partial class FinishedDetailsListForm : Form
    {
        public FinishedDetailsListForm()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void FinishedDetailsListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet._3DModel". При необходимости она может быть перемещена или удалена.
            this._3DModelTableAdapter.Fill(this._3D_PrintingDataSet._3DModel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this._3D_PrintingDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.FinishedDetail". При необходимости она может быть перемещена или удалена.
            this.finishedDetailTableAdapter.Fill(this._3D_PrintingDataSet.FinishedDetail);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this._3D_PrintingDataSet.Order);

        }

        private void SaveItemtoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.finishedDetailBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка при заполнении списка готовых заказов!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        static FinishedDetailsListForm f;
        static public FinishedDetailsListForm fdlf
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FinishedDetailsListForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void finishedDetailDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
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

        private void finishedDetailDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((finishedDetailDataGridView.Rows[e.RowIndex]
                     .Cells["DataGridViewCheckBoxColumnDetailStatus"].Value
                 == null)
                || (finishedDetailDataGridView.Rows[e.RowIndex]
                        .Cells["DataGridViewCheckBoxColumnDetailStatus"
                        ]
                        .Value.ToString()
                    == ""))
            {
                e.CellStyle.BackColor = Color.White;
            }
            else if (finishedDetailDataGridView.Rows[e.RowIndex]
                         .Cells["DataGridViewCheckBoxColumnDetailStatus"
                         ]
                         .Value.ToString()
                     == "True")
            {
                e.CellStyle.BackColor = Color.LightGreen;

            }
            else
            {
                e.CellStyle.BackColor = Color.Pink;
            }
        }


        string GetSelectedFieldName()
        {
            return
                finishedDetailDataGridView.Columns[finishedDetailDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void finishedDetailDataGridView_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (String.Compare(GetSelectedFieldName(), "О_моделе", false) == 0)
            {
                decimal price = 0;
                int idDishCurrent = -1;

                int.TryParse((((DataRowView) finishedDetailBindingSource.Current)["ModelID"]).ToString(), out idDishCurrent);
                int idDish = ModelsForm.md.ShowSelectForm(
                    idDishCurrent,
                    out price);
                MessageBox.Show("ModelID=" + idDish.ToString());
                ((DataRowView)finishedDetailBindingSource.Current)["ModelID"] =
                    idDish;
                ((DataRowView)finishedDetailBindingSource.Current)["ModelID"] = price;
                finishedDetailBindingSource.EndEdit();
                finishedDetailTableAdapter.Update(this._3D_PrintingDataSet);
                _3DModelTableAdapter.Fill(this._3D_PrintingDataSet._3DModel);
            }
        }
    }
}
