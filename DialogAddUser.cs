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
    public partial class DialogAddUser : Form
    {
        public DialogAddUser()
        {
            InitializeComponent();
            RoleComboBox.ValueMember = "Id";
            RoleComboBox.DisplayMember = "Text";
            RoleComboBox.Items.Add(new Role(2, "Пользователь")); 
            if (Program.SelectUser.Role == 0)
            {
                RoleComboBox.Items.Add(new Role(1, "Администратор"));
            }         
            RoleComboBox.SelectedItem = RoleComboBox.Items[0];
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text == RePassTextBox.Text)
            {
                if (Users.AddUser(LoginTextBox.Text, PassTextBox.Text))
                {
                    User user = Users.GetUser(LoginTextBox.Text);
                    user.Role = ((Role)RoleComboBox.SelectedItem).Id;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка создания пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class Role
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Role(int id, string text)
        {
            Id = id;
            Text = text;
        }

    }
}
