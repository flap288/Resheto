using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resheto
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = RegLogin.Text;
            string pwd = RegPwd.Text;
            if (login.Contains('\'')|| login.Contains('-')|| string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Логин содержит недопустимые символы");
                return;
            }
            if (pwd.Contains('\'')|| pwd.Contains('!')|| string.IsNullOrEmpty(pwd)|| pwd.Contains('?')|| pwd.Contains(','))
            {
                MessageBox.Show("Пароль содержит недопустимые символы");
                return;
            }
            DBManager dBManager = new DBManager("D:\\DataBase\\users.db");
            if (dBManager.AddUser(RegLogin.Text, RegPwd.Text))
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Не удалось");
            }
        }

        private void RegLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
