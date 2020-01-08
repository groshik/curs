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
    public partial class CreateAdminForm : Form
    {
        public CreateAdminForm()
        {
            InitializeComponent();
        }
        private User createdUser;
        public User GetCreateUser()
        {
            return createdUser;
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text == RePassTextBox.Text)
            {
                if (!Users.Extant(LoginTextBox.Text))
                {
                    if (Users.AddUser(LoginTextBox.Text, PassTextBox.Text))
                    {
                        createdUser = Users.GetUser(LoginTextBox.Text);
                        createdUser.Role = 0;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Имя пользователя занято", "Ошибка создания пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка создания пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                RePassTextBox.Focus();
            }
        }

        private void RePassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CreateButton_Click(CreateButton, new EventArgs());
            }
        }
    }
}
