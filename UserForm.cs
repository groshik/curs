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
    public partial class UserForm : Form
    {
        private bool nosave;
        private int SortColumn = -1;
        private bool NoSave
        {
            get
            {
                return nosave;
            }
            set
            {
                nosave = value;
                if (nosave)
                {
                    saveUsersButton.Enabled = true;
                    censelUsersButton.Enabled = true;
                }
                else
                {
                    saveUsersButton.Enabled = false;
                    censelUsersButton.Enabled = false;
                }
            }
        }
        private readonly MainForm mainForm;
        public UserForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
            if (Program.SelectUser.Role == 2)
            {
                addUserButton.Enabled = false;
                deleteUserButton.Enabled = false;
            }
            userGridView.ForeColor = System.Drawing.Color.Black;
            addUserButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            deleteUserButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            censelUsersButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            saveUsersButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            userGridView.DataSource = Users.GetUsersList();
            DataGridViewColumnCollection columns = userGridView.Columns;
            columns[0].HeaderText = "Логин";
            columns[1].HeaderText = "Пароль";
            columns[2].Visible = false;
            columns[3].HeaderText = "Роль";
            NoSave = false;
            Users.ChangeDataInListEvent += UpdateUserData;
        }
        private void UpdateUserData()
        {
            NoSave = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (DialogAddUser adminadddUserForm = new DialogAddUser())
            {
                DialogResult resultUserForm = adminadddUserForm.ShowDialog();
                if (resultUserForm == DialogResult.OK)
                {
                    userGridView.DataSource = Users.GetUsersList();
                    NoSave = true;
                }
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NoSave)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Users.Save();
                }
                else if (result == DialogResult.No)
                {
                    Users.Load();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (Users.DeleteUsert((User)userGridView.CurrentRow.DataBoundItem))
            {
                userGridView.DataSource = Users.GetUsersList();
                NoSave = true;
            }
        }

        private void saveUsersButton_Click(object sender, EventArgs e)
        {
            Users.Save();
            NoSave = false;
            userGridView.DataSource = Users.GetUsersList();
        }

        private void censelUsersButton_Click(object sender, EventArgs e)
        {
            Users.Load();
            NoSave = false;
            userGridView.DataSource = Users.GetUsersList();
        }

        private Point mouseLocation;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation);
                Location = mousePose;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            panel4_MouseDown(sender, e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            panel4_MouseMove(sender, e);
        }

        private void userGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<User> userList = Users.GetUsersList();
            int AscDesc = 1;
            if (SortColumn == e.ColumnIndex)
            {
                AscDesc = -1;
                SortColumn = -1;
            }
            else
            {
                SortColumn = e.ColumnIndex;
            }
            userList.Sort((x, y) => {
                var Property_1 = x.GetType().GetProperty(userGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(x, null);
                var Property_2 = y.GetType().GetProperty(userGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(y, null);
                string Prop_1 = Property_1 != null ? Property_1.ToString() : "";
                string Prop_2 = Property_2 != null ? Property_2.ToString() : "";
                if (Double.TryParse(Prop_1, out double Prop_1_double) && Double.TryParse(Prop_2, out double Prop_2_double))
                {
                    if (Prop_1_double > Prop_2_double)
                        return 1 * AscDesc;
                    else if (Prop_1_double < Prop_2_double)
                        return -1 * AscDesc;
                    else
                        return 0;
                }
                else
                {
                    if (AscDesc == 1)
                        return Program.CheckString(Prop_1, Prop_2);
                    else
                        return Program.CheckString(Prop_2, Prop_1);
                }
            });
            userGridView.DataSource = userList.ToList();
        }
    }
}
