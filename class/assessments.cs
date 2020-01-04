using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Curs
{
    class Assessments : IDisposable
    {
        public DateTime Start_Period { get; set; }
        public DateTime Finish_Period { get; set; }
        private List<AssessmentsStudent> StudentList { get; set; }
        private List<int> SubjectsList { get; set; }
        private DataGridView Table { get; set; }
        private TextBox StipendBox { get; set; }
        private DateTimePicker StartPeriodPicker { get; set; }
        private DateTimePicker FinishPeriodPicker { get; set; }
        public void Dispose()
        {
            Table.CellValueChanged -= UpdateData;
            StipendBox.TextChanged -= TextChanged;
        }
        private void UpdateData(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData();
        }
        private void TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public Assessments(DataGridView grid, TextBox text, DateTimePicker start, DateTimePicker finish)
        {
            Table = grid;
            StipendBox = text;
            StudentList = new List<AssessmentsStudent>();
            SubjectsList = new List<int>();
            Table.CellValueChanged += UpdateData;
            StipendBox.TextChanged += TextChanged;
            Start_Period = DateTime.Now;
            Finish_Period = DateTime.Now;
            StartPeriodPicker = start;
            FinishPeriodPicker = finish;
            start.DataBindings.Clear();
            finish.DataBindings.Clear();
            start.DataBindings.Add("Value", this, "Start_Period", true, DataSourceUpdateMode.OnPropertyChanged);
            finish.DataBindings.Add("Value", this, "Finish_Period", true, DataSourceUpdateMode.OnPropertyChanged);
            UpdateTable();
        }

        public void AddStudent(int student)
        {
            bool isSet = false;
            StudentList.ForEach(stud => {
                if (stud.IdStudent == student)
                {
                    isSet = true;
                    return;
                }
            });
            if (!isSet)
            {
                AssessmentsStudent newStudent = new AssessmentsStudent(student);
                SubjectsList.ForEach(subject =>
                {
                    newStudent.AssessmentsList.Add(subject, 0);
                });
                StudentList.Add(newStudent);
            }
            UpdateTable();
        }
        public void AddStudent(Student student)
        {
            AddStudent(student.Id);
        }
        public void RemoveStudent(int student, bool updata = true)
        {
            StudentList.RemoveAll(stud => stud.IdStudent == student);
            if (updata)
                UpdateTable();
        }
        public void RemoveStudent(Student student)
        {
            RemoveStudent(student.Id);
        }
        public void RemoveSelectStudent()
        {
            if (Table.CurrentRow != null)
            {
                AssessmentsStudent student = (AssessmentsStudent)Table.CurrentRow.Tag;
                RemoveStudent(student.IdStudent);
            }        
        }
        public void AddSubject(int subject)
        {
            if (!SubjectsList.Contains(subject))
            {
                SubjectsList.Add(subject);
                StudentList.ForEach(stud =>
                {
                    stud.AssessmentsList.Add(subject, 0);
                });
            }
            UpdateTable();
        }
        public void AddSubject(Subject subject)
        {
            AddSubject(subject.Id);
        }
        public void RemoveSubject(int subject)
        {
            if (SubjectsList.Contains(subject))
            {
                SubjectsList.Remove(subject);
                StudentList.ForEach(stud =>
                {
                    if (stud.AssessmentsList.ContainsKey(subject))
                        stud.AssessmentsList.Remove(subject);
                });
            }
        }
        public void RemoveSelectSubject()
        {
           
            if (Table.SelectedCells[0] != null)
            {
                int indexCol = Table.SelectedCells[0].ColumnIndex;
                string name = Table.Columns[indexCol].Name;
                if (Int32.TryParse(name, out int index))
                {
                    RemoveSubject(index);
                }
            }
        }
        public void UpdateTable()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.CellValueChanged -= UpdateData;
            SubjectsList.ForEach(subject => {
                Subject subjectInfo = Subjects.GetSubjectByID(subject);
                DataGridViewColumn newCol = new DataGridViewColumn()
                {
                    Name = subjectInfo.Id.ToString(),
                    HeaderText = subjectInfo.Title,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    CellTemplate = new DataGridViewTextBoxCell()
                };
                
                Table.Columns.Add(newCol);
            });

            DataGridViewColumn averageAssessmentCol = new DataGridViewColumn
            {
                ReadOnly = true,
                HeaderText = "Средняя оценка",
                CellTemplate = new DataGridViewTextBoxCell(),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(200, 200, 200)
                }
            };
            Table.Columns.Add(averageAssessmentCol);
            DataGridViewColumn stipendCol = new DataGridViewColumn
            {
                ReadOnly = true,
                HeaderText = "Стипендия",
                CellTemplate = new DataGridViewTextBoxCell(),
            };
            Table.Columns.Add(stipendCol);
            List<int> removeStudents = new List<int>();
            StudentList.ForEach(student => 
            {
                Student studentInfo = Students.GetStudentByID(student.IdStudent);
                if (studentInfo == null)
                {
                    removeStudents.Add(student.IdStudent);
                }
            });
            removeStudents.ForEach(remove =>
            {
                RemoveStudent(remove, false);
            });
            StudentList.ForEach(student => 
            {
                Student studentInfo = Students.GetStudentByID(student.IdStudent);
                DataGridViewRow row = new DataGridViewRow();
                string studentName = studentInfo.FullName + " (" + Groups.GetGroupByID(studentInfo.Id_Group).Number + ")";
                row.HeaderCell.Value = studentName;
                row.Tag = student;
                Table.Rows.Add(row);
                int RowHeaderWidth = 9 * studentName.Length;
                if (RowHeaderWidth > Table.RowHeadersWidth)
                {
                    Table.RowHeadersWidth = RowHeaderWidth;
                }
            });
            int i = 0, j = 0;
            StudentList.ForEach(stud =>
            {
                j = 0;
                double averageAssessment = 0;
                double assessmentCounr = 0;
                SubjectsList.ForEach(subj =>
                {
                    int assessments = stud.AssessmentsList[subj];
                    averageAssessment += assessments;
                    assessmentCounr++;
                    Table[j, i].Value = assessments;
                    j++;
                });
                averageAssessment /= assessmentCounr;
                Table[j, i].Value = Math.Round(averageAssessment, 2);
                Student student = Students.GetStudentByID(stud.IdStudent);
                double allowance = 0;
                if (averageAssessment >= 9 && student.Active_Participation)
                {
                    allowance = 1.5;
                    Table[j + 1, i].Style.BackColor = System.Drawing.Color.FromArgb(28, 193, 243);
                }
                else if (averageAssessment >= 9)
                {
                    allowance = 1.25;
                    Table[j + 1, i].Style.BackColor = System.Drawing.Color.FromArgb(80, 216, 103);
                }
                else if (averageAssessment > 5)
                {
                    allowance = 1;

                }
                else
                {
                    Table[j + 1, i].Style.BackColor = System.Drawing.Color.FromArgb(253, 81, 81);
                }
                Double.TryParse(StipendBox.Text, out double stipend);
                stipend *= allowance;
                Table[j + 1, i].Value = Math.Round(stipend, 2);
                i++;
            });
            Table.CellValueChanged += UpdateData;
        }
        public void UpdateData()
        {
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
                    AssessmentsStudent student = (AssessmentsStudent)Table.Rows[r].Tag;
                    student.AssessmentsList[Int32.Parse(Table.Columns[c].Name)] = assessment;
                }
            }
            UpdateTable();
        }
        public void Save(string fileName)
        {
            using (StreamWriter fileStream = new StreamWriter(fileName, false, System.Text.Encoding.UTF8))
            {
                fileStream.WriteLine("CPF");
                fileStream.WriteLine(StipendBox.Text);
                fileStream.WriteLine(Start_Period.ToString());
                fileStream.WriteLine(Finish_Period.ToString());        
                string subjectString = "";
                SubjectsList.ForEach(subj =>               
                {
                    subjectString += (subj.ToString()+ " ");
                });
                fileStream.WriteLine(subjectString);
                StudentList.ForEach(stud =>
                {
                    fileStream.Write(stud.IdStudent.ToString() + " - ");
                    string assessmentString = "";
                    foreach (KeyValuePair<int, int> entry in stud.AssessmentsList)
                    {
                        assessmentString += (entry.Key.ToString() + ":" + entry.Value.ToString() + " ");
                    }
                    fileStream.WriteLine(assessmentString);
                });
            }
            
        }
        public bool Load(string fileName)
        {
            using (StreamReader fileStream = new StreamReader(fileName, System.Text.Encoding.UTF8))
            {
                StudentList.Clear();
                SubjectsList.Clear();
                string checkString = fileStream.ReadLine();
                if (!checkString.Equals("CPF")) return false;
                string stipend = fileStream.ReadLine();
                StipendBox.Text = stipend;
                string startPeriod = fileStream.ReadLine();
                Start_Period = DateTime.Parse(startPeriod);
                StartPeriodPicker.Value = Start_Period;
                string finishPeriod = fileStream.ReadLine();
                Finish_Period = DateTime.Parse(finishPeriod);
                FinishPeriodPicker.Value = Finish_Period;
                List<int> subjects = Program.StringInListInt(fileStream.ReadLine(), ' ');
                SubjectsList = subjects;
                while (!fileStream.EndOfStream)
                {
                    string student = fileStream.ReadLine();
                    GetStudentOfStreamLine(student, out string idStudent, out string assessmentStudent);
                    AssessmentsStudent assessmentsStudent = new AssessmentsStudent(Int32.Parse(idStudent));
                    List<string> assessmentsList = Program.StringInListString(assessmentStudent, ' ');
                    assessmentsList.ForEach(assessment =>
                    {
                        assessmentsStudent.GetAssessmentOfStreamLine(assessment);
                    });
                    StudentList.Add(assessmentsStudent);
                }
                UpdateTable();
                return true;
            }

        }
        public void GetStudentOfStreamLine(string str, out string stud, out string assessments)
        {
            int delimiter = str.IndexOf('-');
            stud = str.Substring(0, delimiter -1);
            assessments = str.Substring(delimiter + 1, (str.Length - 1) - (delimiter + 1));
        }

    }
    class AssessmentsStudent
    {
        public int IdStudent;
        public Dictionary<int, int> AssessmentsList;
        public AssessmentsStudent(int student)
        {
            IdStudent = student;
            AssessmentsList = new Dictionary<int, int>();
        }
        public void GetAssessmentOfStreamLine(string str)
        {
            int delimiter = str.IndexOf(':');
            string subj = str.Substring(0, delimiter);
            string assessment = str.Substring(delimiter + 1, (str.Length - 1) - (delimiter));
            AssessmentsList.Add(Int32.Parse(subj), Int32.Parse(assessment));
        }
    }


}
