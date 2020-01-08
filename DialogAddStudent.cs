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
    public partial class GreetingsForm : Form
    {
        public GreetingsForm()
        {
            InitializeComponent();
            StudentListBox.DataSource = Students.Items.Where(student => !student.Paid_Form_Of_Study).ToList();
            StudentListBox.DisplayMember = "FullName";
            StudentListBox.ValueMember = "Id";
            Group allGroup = new Group(0, "Все группы");
            List<Group> gruops = new List<Group>
            {
                allGroup
            };
            gruops.AddRange(Groups.Items.ToList());
            groupComboBox.DataSource = gruops;
            groupComboBox.DisplayMember = "Number";
            groupComboBox.ValueMember = "Id";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public List<int> GetStudents()
        {
            List<int> listStudent = new List<int>();      
            foreach (Student studet in StudentListBox.SelectedItems)
            {      
                listStudent.Add(studet.Id);
            }
            return listStudent;
        }
        private void SerchBox_Enter(object sender, EventArgs e)
        {
            if (SerchBox.Text == "Поиск...")
            {
                SerchBox.Text = "";
                SerchBox.ForeColor = SystemColors.WindowText;
            }
        }
        private void SerchBox_Leave(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                SerchBox.Text = "Поиск...";
                SerchBox.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void SerchBox_KeyUp(object sender, KeyEventArgs e)
        {
            StudentListBox.DataSource = Students.Items.Where(student => student.FullFullName.ToLower().Contains(SerchBox.Text.ToLower())).ToList();
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox.SelectedItem;
            if (selectGroup.Id != 0)
                StudentListBox.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                StudentListBox.DataSource = Students.Items.ToList();
        }
    }
}
