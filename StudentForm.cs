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
            
            Group allGroup = new Group();
            allGroup.Id = 0;
            allGroup.Number = "Все Группы";
            List<Group> gruops = new List<Group>();
            gruops.Add(allGroup);
            gruops.AddRange(Groups.Items.ToList());
            
            groupComboBox1.DataSource = gruops;
            groupComboBox1.DisplayMember = "Number";
            groupComboBox1.ValueMember = "Id";
            NoSave = false;
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void GroupComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            studentGridView.Columns.Clear();
            if (selectGroup.Id != 0)
                studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = Students.Items.ToList();
            DataGridViewColumnCollection columns = studentGridView.Columns;

            columns[0].Visible = false;
            columns[1].HeaderText = "Фамилия";
            columns[2].HeaderText = "Имя";
            columns[3].HeaderText = "Отчество";
            columns[4].Visible = false;
            columns[5].HeaderText = "Платная форма обучения";
            columns[6].HeaderText = "Активное участие в общественной деятельности";
            columns[7].Visible = false;
            columns[8].Visible = false;
            DataGridViewComboBoxColumn checkCol = new DataGridViewComboBoxColumn();
            checkCol.DataSource = Groups.Items;
            checkCol.DataPropertyName = "ID_Group";
            checkCol.Name = "Group";
            checkCol.DisplayMember = "Number";
            checkCol.ValueMember = "ID";
            checkCol.HeaderText = "Группа";
            studentGridView.Columns.Add(checkCol);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.AddStudent(selectGroup);
            if (selectGroup.Id != 0)
                studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = Students.Items.ToList();
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
            if (selectGroup.Id != 0)
                studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = Students.Items.ToList();
            NoSave = true;
        }

        private void SaveStudentsButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.Save();
            NoSave = false;
            if (selectGroup.Id != 0)
                studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = Students.Items.ToList();
        }

        private void CenselStudentsButton_Click(object sender, EventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            Students.Load();
            NoSave = false;
            if (selectGroup.Id != 0)
                studentGridView.DataSource = Students.Items.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = Students.Items.ToList();
        }

        private void StudentGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NoSave = true;
        }

        private void StudentGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        public void test(object sender, EventArgs e)
        {

        }

        private void StudentGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            NoSave = false;
            List<Student> studentList = Students.Items.ToList();
            studentList.Sort((x, y) => {
                var Property_1 = x.GetType().GetProperty(studentGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(x);
                var Property_2 = y.GetType().GetProperty(studentGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(y);
                string Prop_1 = Property_1 != null ? Property_1.ToString() : "";
                string Prop_2 = Property_2 != null ? Property_2.ToString() : "";
                return Program.CheckString(Prop_1, Prop_2);
             });
            if (selectGroup.Id != 0)
                studentGridView.DataSource = studentList.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = studentList.ToList();
        }
    }
}
