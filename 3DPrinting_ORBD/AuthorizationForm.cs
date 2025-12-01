using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPrinting_ORBD
{
    public partial class AuthorizationForm : Form
    {
        private string _login, _password;
        private SqlConnection _connection;

        private void OkButton_Click(object sender, EventArgs e)
        {
            _login = LoginTextBox.Text;
            _password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(_login) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = $@"Data Source=TIMUR_HONOR\SQLEXPRESS; 
                                Initial Catalog=3D printing; 
                                User id={_login}; 
                                Password={_password}";
            _connection.ConnectionString = connectionString;
            try
            {
                _connection.Open();
                Form form = new MainForm();
                form.FormClosing += (object obj, FormClosingEventArgs ev) => { this.Close(); };
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }

        }
        public AuthorizationForm()
        {
            InitializeComponent();
            _connection = new SqlConnection();
        }
    }
}
