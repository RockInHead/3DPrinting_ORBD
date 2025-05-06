using System;
using System.Windows.Forms;


namespace _3DPrinting_ORBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
                           "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                       DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Рафиков Тимур Русланович, группа 573-2 , 2025", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelsForm.md.ShowForm();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm.cf.ShowForm();

        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders.of.ShowForm();
        }
    }
}
