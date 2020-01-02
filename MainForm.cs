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
                if (indexReportCard != null)
                    indexReportCard.Dispose();
                indexReportCard = value;
                if (indexReportCard != null)
                {
                    SaveMenuItem.Enabled = true;
                    SaveAsMenuItem.Enabled = true;
                    ReportCardPanel.Visible = true;
                }
                else
                {
                    SaveMenuItem.Enabled = false;
                    SaveAsMenuItem.Enabled = false;
                    ReportCardPanel.Visible = false;
                }
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
        }-
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
            IndexReportCard = new Assessments(AssessmentGrid, StipendBox, DateStartPicker, DateFinishPicker);
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

        }
        private void DateStartPicker_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexReportCard != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    IndexReportCard.Save(saveFileDialog.FileName);
                }
            }          
        }
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IndexReportCard = new Assessments(AssessmentGrid, StipendBox, DateStartPicker, DateFinishPicker);              
                if (IndexReportCard.Load(openFileDialog.FileName)) 
                {
                    saveFileDialog.FileName = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка чтения файла");
                }
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.FileName != "")
            {
                IndexReportCard.Save(saveFileDialog.FileName);
            }
            else
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    IndexReportCard = new Assessments(AssessmentGrid, StipendBox, DateStartPicker, DateFinishPicker);
                    ReportCardPanel.Visible = true;
                    IndexReportCard.Save(saveFileDialog.FileName);
                }
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            IndexReportCard.RemoveSelectStudent();
        }
    }
}
