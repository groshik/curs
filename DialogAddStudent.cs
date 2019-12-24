using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs
{
    public partial class DialogAddStudent : Form
    {
        public DialogAddStudent()
        {
            InitializeComponent();
            StudentListBox.DataSource = Students.Items.Where(student => !student.Paid_Form_Of_Study).ToList();
            StudentListBox.DisplayMember = "FullName";
            StudentListBox.ValueMember = "Id";
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
            if (string.IsNullOrWhiteSpace(SerchBox.Text))
            {
                SerchBox.Text = "Поиск...";
                SerchBox.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void SerchBox_KeyUp(object sender, KeyEventArgs e)
        {
            StudentListBox.DataSource = Students.Items.Where(student => student.FullFullName.ToLower().Contains(SerchBox.Text.ToLower())).ToList();
        }
    }
}
