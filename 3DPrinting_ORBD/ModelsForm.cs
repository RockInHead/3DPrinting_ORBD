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
    public partial class ModelsForm : Form
    {
        public ModelsForm()
        {
            InitializeComponent();
        }

        private void _3DModelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._3DModelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3D_PrintingDataSet);

        }

        private void ModelsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3D_PrintingDataSet._3DModel". При необходимости она может быть перемещена или удалена.
            this._3DModelTableAdapter.Fill(this._3D_PrintingDataSet._3DModel);

        }
    }
}
