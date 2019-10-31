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
    public partial class StudentForm : Form
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
                    saveStudentsButton.Enabled = true;
                    censelStudentsButton.Enabled = true;
                }
                else
                {
                    saveStudentsButton.Enabled = false;
                    censelStudentsButton.Enabled = false;
                }
            }
        }

        private readonly MainForm mainForm;
        public StudentForm(MainForm form)
        {
            mainForm = form;        
            InitializeComponent();
            NoSave = false;
            groupComboBox1.DataSource = Groups.Items;
            groupComboBox1.DisplayMember = "Number";
            groupComboBox1.ValueMember = "Id";
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void GroupComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            studentGridView.Columns.Clear();
            studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            DataGridViewColumnCollection columns = studentGridView.Columns;
            columns[0].Visible = false;
            columns[1].HeaderText = "Фамилия";
            columns[2].HeaderText = "Имя";
            columns[3].HeaderText = "Отчество";
            columns[4].Visible = false;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.AddStudent(selectGroup);
            studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            studentGridView.CurrentCell = studentGridView[1, studentGridView.RowCount - 1];
            NoSave = true;
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NoSave)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Students.Save();
                }
                else if (result == DialogResult.No)
                {
                    Students.Load();
                }
                else
                {
                    e.Cancel = true;
                }
            }           
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.DeleteStudent((Student)studentGridView.CurrentRow.DataBoundItem);
            studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            NoSave = true;
        }

        private void SaveStudentsButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.Save();
            NoSave = false;
            studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
        }

        private void CenselStudentsButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.Load();
            NoSave = false;
            studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
        }

        private void StudentGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NoSave = true;
        }
    }
}
