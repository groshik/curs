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
    public partial class StudentForm : Form
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

            Group allGroup = new Group
            {
                Id = 0,
                Number = "Все Группы"
            };
            List<Group> gruops = new List<Group>
            {
                allGroup
            };
            gruops.AddRange(Groups.Items.ToList());
            
            groupComboBox1.DataSource = gruops;
            groupComboBox1.DisplayMember = "Number";
            groupComboBox1.ValueMember = "Id";
            NoSave = false;
            Students.ChangeDataInListEvent += UpdateStudentData;
        }
        private void UpdateStudentData()
        {
            NoSave = true;
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
            //DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
            //_ = checkCell;
            columns[5].HeaderText = "Платная форма обучения";
            columns[6].HeaderText = "Активное участие в общественной деятельности";
            columns[7].Visible = false;
            columns[8].Visible = false;
            DataGridViewComboBoxColumn comboCol = new DataGridViewComboBoxColumn();
            List<Group> listGroup = new List<Group>();
            Group noGroup = new Group
            {
                Id = 0,
                Number = "Нет группы"
            };
            listGroup.Add(noGroup);
            listGroup.AddRange(Groups.Items);
            comboCol.DataSource = listGroup;
            comboCol.DataPropertyName = "Id_Group";
            comboCol.Name = "Group";
            comboCol.DisplayMember = "Number";
            comboCol.ValueMember = "ID";
            comboCol.HeaderText = "Группа";
            studentGridView.Columns.Add(comboCol);
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
        private void StudentGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Group selectGroup = (Group)groupComboBox1.SelectedItem;
            List<Student> studentList = Students.Items.ToList();
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
            studentList.Sort((x, y) => {               
                var Property_1 = x.GetType().GetProperty(studentGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(x, null);
                var Property_2 = y.GetType().GetProperty(studentGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(y, null);
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
            if (selectGroup.Id != 0)
                studentGridView.DataSource = studentList.Where(student => student.Id_Group == selectGroup.Id).ToList();
            else
                studentGridView.DataSource = studentList.ToList();
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
