using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignIn : Form
    {
        string userPassword = "",
            password = "Пароль1",
            userLogin = "",
            login = "Логин";

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) passwordTextBox.Select();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SingInButton_Click(sender, e);
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
        }

        public SignIn()
        {
            InitializeComponent();
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void SingInButton_Click(object sender, EventArgs e)
        {
            userLogin = loginTextBox.Text;
            if (userPassword == password && userLogin == login) Close();
            else 
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка");
                return;
            }
        }
    }
}
