using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SotnikovAgency
{
    public partial class FormLogin : Form
    {
        
        SqlCommand command;
        SqlConnection connection;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            command = new SqlCommand();
            connection = new SqlConnection();
            string log = this.textBoxLogin.Text;
            string passwd = this.textBoxPasswd.Text;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ Log ", log);
            command.Parameters.AddWithValue("@ Pas ", passwd);
            command.CommandText = Total.commandText;

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read() == false)
            {
                MessageBox.Show("Таких данных нет в БД.");
                return;
            }
            else
            {
                //переход на некст форму
            }
        }
        private void buttonBackToMain_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
