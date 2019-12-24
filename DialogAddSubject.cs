using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Curs
{
    public partial class DialogAddSubject : Form
    {
        public DialogAddSubject()
        {
            InitializeComponent();
            SubjectListBox.DataSource = Subjects.Items;
            SubjectListBox.DisplayMember = "Title";
            SubjectListBox.ValueMember = "Id";
        }
        public List<int> GetSubject()
        {
            List<int> listSubject = new List<int>();
            foreach (Subject subject in SubjectListBox.SelectedItems)
            {
                listSubject.Add(subject.Id);
            }
            return listSubject;
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
            SubjectListBox.DataSource = Subjects.Items.Where(subject => subject.Title.ToLower().Contains(SerchBox.Text.ToLower())).ToList();
        }
    }
}
