﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Curs
{
    public partial class SubjectForm : Form
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
            if (Program.SelectUser.Role == 2)
            {
                addSubjectButton.Enabled = false;
                deleteSubjectButton.Enabled = false;
            }
            subjectGridView.ForeColor = System.Drawing.Color.Black;
            addSubjectButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            deleteSubjectButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            censelSubjectsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            saveSubjectsButton.Paint += new System.Windows.Forms.PaintEventHandler(Program.Button_Paint);
            subjectGridView.DataSource = Subjects.Items.ToList();
            DataGridViewColumnCollection columns = subjectGridView.Columns;
            columns[0].Visible = false;
            
            columns[1].HeaderText = "Предмет";
            NoSave = false;
            Subjects .ChangeDataInListEvent += UpdateStudentData;
        }
        private void UpdateStudentData()
        {
            NoSave = true;
        }
        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            if (Subjects.AddSubject())
            {
                subjectGridView.DataSource = Subjects.Items.ToList();
                subjectGridView.CurrentCell = subjectGridView[1, subjectGridView.RowCount - 1];
                NoSave = true;
            }
        }

        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            if (Subjects.DeleteStudent((Subject)subjectGridView.CurrentRow.DataBoundItem))
            {
                subjectGridView.DataSource = Subjects.Items.ToList();
                NoSave = true;
            }
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

        private void SubjectGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Subject> subjectList = Subjects.Items.ToList();
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
            subjectList.Sort((x, y) => {
                var Property_1 = x.GetType().GetProperty(subjectGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(x, null);
                var Property_2 = y.GetType().GetProperty(subjectGridView.Columns[e.ColumnIndex].DataPropertyName).GetValue(y, null);
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
            subjectGridView.DataSource = subjectList.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Point mouseLocation;
        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation);
                Location = mousePose;
            }
        }
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Panel4_MouseDown(sender, e);
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            Panel4_MouseMove(sender, e);
        }
    }
}
