using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Curs
{
    class Assessments
    {
        private DateTime Start_Period { get; set; }
        private DateTime Finish_Period { get; set; }
        private List<int> ID_Students { get; set; }
        private List<int> ID_Subjects { get; set; }
        private int[,] Assessments_List { get; set; }
        private DataGridView Table { get; set; }
        private TextBox averageAssessmentBox { get; set; }
        private void updateData(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData();
        }

        public Assessments(DataGridView grid, TextBox text)
        {
            Table = grid;
            averageAssessmentBox = text;
            ID_Students = new List<int>();
            ID_Subjects = new List<int>();
            Assessments_List = new  int[0,0];
            Table.CellValueChanged += updateData;
        }

        public void AddStudent(int student)
        {
            if (!ID_Students.Contains(student))
            {
                ID_Students.Add(student);
                UpdateStruct();
                UpdateTable();
            }
        }
        public void AddStudent(Student student)
        {
            AddStudent(student.Id);
        }
        public void AddSubject(int subject)
        {
            if (!ID_Subjects.Contains(subject))
            {
                ID_Subjects.Add(subject);
                UpdateStruct();
                UpdateTable();
            }
        }
        public void AddSubject(Subject subject)
        {
            AddSubject(subject.Id);
        }
        public void UpdateTable()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.CellValueChanged -= updateData;
            ID_Subjects.ForEach(subject => {
                Subject subjectInfo = Subjects.GetSubjectByID(subject);
                Table.Columns.Add(subjectInfo.Id.ToString(), subjectInfo.Title);
            });

            DataGridViewColumn averageAssessmentCol = new DataGridViewColumn();
            averageAssessmentCol.ReadOnly = true;
            averageAssessmentCol.HeaderText = "Средняя оценка";
            averageAssessmentCol.CellTemplate = new DataGridViewTextBoxCell();
            Table.Columns.Add(averageAssessmentCol);

            DataGridViewColumn stipendCol = new DataGridViewColumn();
            stipendCol.ReadOnly = true;
            stipendCol.HeaderText = "Стипендия";
            stipendCol.CellTemplate = new DataGridViewTextBoxCell();
            Table.Columns.Add(stipendCol);

            ID_Students.ForEach(student => {
                Student studentInfo = Students.GetStudentByID(student);
                DataGridViewRow row = new DataGridViewRow();
                string studentName = studentInfo.FullName + " (" + Groups.GetGroupByID(studentInfo.Id_Group).Number + ")";
                row.HeaderCell.Value = studentName;
                Table.Rows.Add(row);
                int RowHeaderWidth = 9 * studentName.Length;
                if (RowHeaderWidth > Table.RowHeadersWidth)
                {
                    Table.RowHeadersWidth = RowHeaderWidth;
                }
            });
            int[,] assessmentList = Assessments_List;
            for (int student = 0; student < ID_Students.Count; student++)
            {
                double averageAssessment = 0;
                for (int assessments = 0; assessments < ID_Subjects.Count; assessments++)
                {
                    Table[assessments, student].Value = assessmentList[student, assessments];
                    averageAssessment += assessmentList[student, assessments];
                }
                averageAssessment = averageAssessment / ID_Subjects.Count;
                Table[ID_Subjects.Count, student].Value = Math.Round(averageAssessment, 2);
                Student stud = Students.GetStudentByID(ID_Students[student]);
                double allowance = 0;
                if (averageAssessment >= 9 && stud.Active_Participation)
                    allowance = 1.5;
                else if (averageAssessment >= 9)
                    allowance = 1.25;
                else if (averageAssessment > 5)
                    allowance = 1;
                double stipend = 0;
                Double.TryParse(averageAssessmentBox.Text, out stipend);
                stipend *= allowance;
                Table[ID_Subjects.Count + 1, student].Value = Math.Round(stipend, 2);
            }
            Table.CellValueChanged += updateData;
        }
        public void UpdateData()
        {
            int[,] listAssessments = new int[ID_Students.Count, ID_Subjects.Count];
            for (int r = 0; r < Table.RowCount; r++)
            {          
                for (int c = 0; c < Table.ColumnCount - 2; c++)
                {
                    int assessment;
                    if (Table[c, r].Value != null)
                    {
                        if (!Int32.TryParse(Table[c, r].Value.ToString(), out assessment))
                        {
                            assessment = 0;
                        }
                    }
                    else
                    {
                        assessment = 0;
                    }
                    if (assessment > 10)
                        assessment = 10;
                    else if (assessment < 0)
                        assessment = 0;
                    listAssessments[r, c] = assessment;
                }
            }
            Assessments_List = listAssessments;
            UpdateTable();
        }
        private void UpdateStruct()
        {
            int[,] newAssessmentsList = new int[ID_Students.Count, ID_Subjects.Count];
            int rows = Assessments_List.GetUpperBound(0) + 1;
            int columns = 0;
            if (rows != 0)
            {
                columns = Assessments_List.Length / rows;
            }           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newAssessmentsList[i, j] = Assessments_List[i, j];
                }
            }
            Assessments_List = newAssessmentsList;
        }
        public void Save(string fileName)
        {
            
        }
        

    }
    
}
