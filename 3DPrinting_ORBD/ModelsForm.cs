using System;
using System.Drawing;
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

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    sreenshotPictureBox.Image = new
                        Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";

        }

        private static ModelsForm m;
        public static ModelsForm md
        {
            get
            {
                if (m == null || m.IsDisposed) m = new ModelsForm();
                return m;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
