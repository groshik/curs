using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs
{
    class Assessments
    {
        private DateTime Start_Period;
        private DateTime Finish_Period;
        private List<int> ID_Students = new List<int>();
        private List<int> ID_Subjects = new List<int>();
        private List<List<int>> Assessments_List = new List<List<int>>();
        private DataGridView Table;

        public Assessments(DataGridView grid)
        {
            Table = grid;
        }

        public void AddStudent(int student)
        {
            ID_Students.Add(student);
        }
        public void AddStudent(Student student)
        {
            ID_Students.Add(student.Id);
        }
        public void AddSubject(int subject)
        {
            ID_Subjects.Add(subject);
        }
        public void AddSubject(Subject subject)
        {
            ID_Subjects.Add(subject.Id);
        }
        public void UpdateTable()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            
            
            ID_Subjects.ForEach(subject => {
                Subject subjectInfo = Subjects.GetSubjectByID(subject);
                Table.Columns.Add(subjectInfo.Id.ToString(), subjectInfo.Title);
            });
            Table.Columns.Add("total", "Стипендия");
            ID_Subjects.ForEach(student => {
                Student studentInfo = Students.GetStudentByID(student);
                DataGridViewRow row = new DataGridViewRow();
                string studentName = studentInfo.Surname + ' ' + studentInfo.Name[0] + '.' + studentInfo.Patronymic[0] + '.';
                row.HeaderCell.Value = studentName;
                Table.Rows.Add(row);
                int RowHeaderWidth = 9 * studentName.Length;
                if (RowHeaderWidth > Table.RowHeadersWidth)
                {
                    Table.RowHeadersWidth = RowHeaderWidth;
                }
            });
        }
    }
    
}
