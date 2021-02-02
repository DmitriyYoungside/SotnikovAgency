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
using yt_DesignUI;
using OSK_project_group;

namespace SotnikovAgency
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        FormLogin formLogin;

        public MainForm()
        {
            InitializeComponent();
        }

        //уведомления
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }


        //перемещение формы
        Point last_point; //для перетаскивания окна
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        //отброс тени по форме
        private const int CS_DropShadow = 0x0020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          

            this.Alert("УспешноAAAAAAAAAAAAA!", Form_Alert.enmType.Error);
            Animator.Start();
            connection = new SqlConnection();
            connection.ConnectionString = Total.connectionString;
            try
            {
                connection.Open();
                MessageBox.Show("Связь с сервером установлена.");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 17: MessageBox.Show("Неверное имя сервера."); break;
                    case 4060: MessageBox.Show("Неверное имя БД."); break;
                    case 18456: MessageBox.Show("Неверное имя пользователя или пароль."); break;
                }
                MessageBox.Show(ex.Message + "Уровень ошибки" + ex.Class); return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения" + ex.Message); return;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            MainForm.ActiveForm.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
