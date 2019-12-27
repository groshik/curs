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
    public partial class GroupForm : Form
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
                    saveGroupsButton.Enabled = true;
                    censelGroupsButton.Enabled = true;
                }
                else
                {
                    saveGroupsButton.Enabled = false;
                    censelGroupsButton.Enabled = false;
                }
            }
        }
        private readonly MainForm mainForm;
        public GroupForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
            groupGridView.DataSource = Groups.Items.ToList();
            DataGridViewColumnCollection columns = groupGridView.Columns;
            columns[0].Visible = false;
            columns[1].HeaderText = "Группа";
            columns[2].HeaderText = "Куратор";
            NoSave = false;
            Groups.ChangeDataInListEvent += UpdateStudentData;
        }
        private void UpdateStudentData()
        {
            NoSave = true;
        }
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            Groups.AddGroup();
            groupGridView.DataSource = Groups.Items.ToList();
            groupGridView.CurrentCell = groupGridView[1, groupGridView.RowCount - 1];
            NoSave = true;
        }
        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            Groups.DeleteStudent((Group)groupGridView.CurrentRow.DataBoundItem);
            groupGridView.DataSource = Groups.Items.ToList();
            NoSave = true;
        }
        private void SaveGroupsButton_Click(object sender, EventArgs e)
        {
            Groups.Save();
            NoSave = false;
            groupGridView.DataSource = Groups.Items.ToList();
        }
        private void CenselGroupsButton_Click(object sender, EventArgs e)
        {
            Groups.Load();
            NoSave = false;
            groupGridView.DataSource = Groups.Items.ToList();
        }
        private void GroupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
        private void GroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NoSave)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Groups.Save();
                }
                else if (result == DialogResult.No)
                {
                    Groups.Load();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void groupGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Group> groupList = Groups.Items.ToList();
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
            groupList.Sort((x, y) => {
                var Property_1 = x.GetType().GetProperty(groupGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(x, null);
                var Property_2 = y.GetType().GetProperty(groupGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(y, null);
                string Prop_1 = Property_1 != null ? Property_1.ToString() : "";
                string Prop_2 = Property_2 != null ? Property_2.ToString() : "";
                double Prop_1_double;
                double Prop_2_double;
                if (Double.TryParse(Prop_1, out Prop_1_double) && Double.TryParse(Prop_2, out Prop_2_double))
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
            groupGridView.DataSource = groupList.ToList();
        }
    }
}
