using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Curs
{
    public partial class MainForm : Form
    {
        private Assessments indexReportCard;
        Assessments IndexReportCard {
            get
            {
                return indexReportCard;
            }
            set
            {
                indexReportCard = value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            Students.ChangeDataInListEvent += () =>
            {
                IndexReportCard?.UpdateTable();
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void StudentsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            new StudentForm(this).Show();
#pragma warning restore IDE0067
        }
        private void GroupButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            new GroupForm(this).Show();
#pragma warning restore IDE0067
        }
        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            new SubjectForm(this).Show();
#pragma warning restore IDE0067
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            using (DialogAddStudent dialog = new DialogAddStudent())
            {
                DialogResult dr = dialog.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    dialog.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    List<int> studentList = dialog.GetStudents();
                    dialog.Close();
                    foreach (int id in studentList)
                    {
                        this.IndexReportCard.AddStudent(id);
                    }
                }
            }
        }
        private void AddGroupStudentsButton_Click(object sender, EventArgs e)
        {
            using (DialogAddGroupStudents dialog = new DialogAddGroupStudents())
            {
                DialogResult dr = dialog.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    dialog.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    dialog.Close();
                }
            }
        }
        private void Scholarship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                string text = StipendBox.Text + e.KeyChar;
                if (!decimal.TryParse(text, out _))
                {
                    e.Handled = true;
                }
            }
        }
        private void Scholarship_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }
        private void CreateMenuItem_Click(object sender, EventArgs e)
        {
            indexReportCard = new Assessments(AssessmentGrid, StipendBox);
            ReportCardPanel.Visible = true;
        }
        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            using (DialogAddSubject dialog = new DialogAddSubject())
            {
                DialogResult dr = dialog.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    dialog.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    List<int> subjectList = dialog.GetSubject();
                    dialog.Close();
                    foreach (int id in subjectList)
                    {
                        this.IndexReportCard.AddSubject(id);
                    }
                }
            }
        }

        private void AssessmentGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StipendBox_TextChanged(object sender, EventArgs e)
        {
            indexReportCard.UpdateTable();
        }
    }
}
