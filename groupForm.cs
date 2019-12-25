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

        private void GroupGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NoSave = true;
        }
    }
}
