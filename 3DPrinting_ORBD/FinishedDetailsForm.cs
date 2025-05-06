using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3DPrinting_ORBD
{
    public partial class FinishedDetailsForm : Form
    {
        public FinishedDetailsForm()
        {
            InitializeComponent();
        }

        private void finishedDetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finishedDetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void FinishedDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet.FinishedDetail". При необходимости она может быть перемещена или удалена.
            this.finishedDetailTableAdapter.Fill(this._3D_PrintingDataSet.FinishedDetail);

        }

        private static FinishedDetailsForm f;
        public static FinishedDetailsForm fd
        {
            get
            {
                if (f == null || f.IsDisposed) f= new FinishedDetailsForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
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
    }
}
