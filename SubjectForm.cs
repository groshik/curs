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
    public partial class SubjectForm : Form
    {
        private bool nosave;
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
                    saveSubjectsButton.Enabled = true;
                    censelSubjectsButton.Enabled = true;
                }
                else
                {
                    saveSubjectsButton.Enabled = false;
                    censelSubjectsButton.Enabled = false;
                }
            }
        }

        private readonly MainForm mainForm;
        public SubjectForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
            subjectGridView.DataSource = Subjects.Items.ToList();
            DataGridViewColumnCollection columns = subjectGridView.Columns;
            columns[0].Visible = false;
            columns[1].HeaderText = "Предмет";
            NoSave = false;
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            Subjects.AddSubject();
            subjectGridView.DataSource = Subjects.Items.ToList();
            subjectGridView.CurrentCell = subjectGridView[1, subjectGridView.RowCount - 1];
            NoSave = true;
        }

        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            Subjects.DeleteStudent((Subject)subjectGridView.CurrentRow.DataBoundItem);
            subjectGridView.DataSource = Subjects.Items.ToList();
            NoSave = true;
        }

        private void SaveSubjectsButton_Click(object sender, EventArgs e)
        {
            Subjects.Save();
            NoSave = false;
            subjectGridView.DataSource = Subjects.Items.ToList();
        }

        private void CenselSubjectsButton_Click(object sender, EventArgs e)
        {
            Subjects.Load();
            NoSave = false;
            subjectGridView.DataSource = Subjects.Items.ToList();
        }

        private void SubjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void SubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NoSave)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Subjects.Save();
                }
                else if (result == DialogResult.No)
                {
                    Subjects.Load();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void SubjectGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NoSave = true;
        }
    }
}
