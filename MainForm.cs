using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            AssessmentGrid.ForeColor = System.Drawing.Color.Black;
            studentsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            groupButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            subjectsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
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
            StudentForm sf = new StudentForm(this);
            sf.Show();
#pragma warning restore IDE0067
        }
        private void GroupsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            GroupForm gf = new GroupForm(this);
            gf.Show();
#pragma warning restore IDE0067
        }
        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            SubjectForm sf = new SubjectForm(this);
            sf.Show();
#pragma warning restore IDE0067
        }
        private void UserButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            UserForm uf = new UserForm(this);
            uf.Show();
#pragma warning restore IDE0067
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            using (GreetingsForm dialog = new GreetingsForm())
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

        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            IndexReportCard.RemoveSelectSubject();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(33,33,33)), new Rectangle(0, e.ClipRectangle.Height - 1, e.ClipRectangle.Width, 1));
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "help\\help.html");
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "help");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(path))
            {
                File.WriteAllText(path, Properties.Resources.Help);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_1.png")))
            {
                Properties.Resources.HelpImage1.Save(Path.Combine(directoryPath, "help_1.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_2.png")))
            {
                Properties.Resources.HelpImage2.Save(Path.Combine(directoryPath, "help_2.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_3.png")))
            {
                Properties.Resources.HelpImage3.Save(Path.Combine(directoryPath, "help_3.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_4.png")))
            {
                Properties.Resources.HelpImage4.Save(Path.Combine(directoryPath, "help_4.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_5.png")))
            {
                Properties.Resources.HelpImage5.Save(Path.Combine(directoryPath, "help_5.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_6.png")))
            {
                Properties.Resources.HelpImage6.Save(Path.Combine(directoryPath, "help_6.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_7.png")))
            {
                Properties.Resources.HelpImage7.Save(Path.Combine(directoryPath, "help_7.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            if (!File.Exists(Path.Combine(directoryPath, "help_8.png")))
            {
                Properties.Resources.HelpImage8.Save(Path.Combine(directoryPath, "help_8.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            System.Diagnostics.Process.Start(path);
        }
    }
    
}
