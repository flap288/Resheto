using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Resheto
{
    public partial class Auth : Form
    {
        private bool _isAuthenticated = false;
        public Auth()
        {
            InitializeComponent();
        }

        private void GoReg_Click(object sender, EventArgs e)
        {
            Reg reg_form = new Reg();
            reg_form.ShowDialog();
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
            {
                Application.Exit();
            }

        }

        private void MakeAuth_Click(object sender, EventArgs e)
        {
            string login = AuthLogin.Text;
            if (login.Contains('\'')|| login.Contains('-'))
            {
                MessageBox.Show("Логин содержит недопустимые символы");
                return;
            }
            DBManager dBManager = new DBManager("D:\\DataBase\\users.db");
            if (dBManager.CheckUser(AuthLogin.Text, AuthPwd.Text))
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось");
            }
        }
    }
}
