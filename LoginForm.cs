using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Curs
{
    public partial class LoginForm : Form
    {
        private User user;
        public LoginForm()
        {
            InitializeComponent();
        }
        public User GetUser()
        {
            return user;
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (Users.Extant(LoginTextBox.Text))
            {
                User selectUser = Users.GetUser(LoginTextBox.Text);
                if (selectUser.Pass == PassTextBox.Text)
                {
                    user = selectUser;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Ошибка авторизации", MessageBoxButtons.OK);
                    PassTextBox.Text = "";
                    PassTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка авторизации", MessageBoxButtons.OK);
                LoginTextBox.Text = "";
                PassTextBox.Text = "";
                LoginTextBox.Focus();
            }
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PassTextBox.Focus();
            }
        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SignInButton_Click(SignInButton, new EventArgs());
            }
        }
    }
}
