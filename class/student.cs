using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Curs
{
    class StudentCollection
    {
        public List<Student> Students { get; set; }
    }
    class Student
    {
        private int id;
        private string surname;
        private string name;
        private string patronymic;
        private int id_group;
        private bool paid_form_of_study;
        private bool active_participation;
        public int Id { get { return id; } 
            set 
            {
                id = value;
                ChangeDataEvent?.Invoke();
            } 
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    surname = value;
                    ChangeDataEvent?.Invoke();
                }
                    
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    name = value;
                    ChangeDataEvent?.Invoke();
                }
                    
            }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    patronymic = value;
                    ChangeDataEvent?.Invoke();
                }
                    
            }
        }
        public int Id_Group
        {
            get { return id_group; }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    id_group = value;
                    ChangeDataEvent?.Invoke();
                }                  
            }
        }
        public bool Paid_Form_Of_Study
        {
            get { return paid_form_of_study; }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    paid_form_of_study = value;
                    ChangeDataEvent?.Invoke();
                }
                    
            }
        }
        public bool Active_Participation
        {
            get { return active_participation; }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    active_participation = value;
                    ChangeDataEvent?.Invoke();
                }
                    
            }
        }
        public string FullName
        {
            get
            {
                string fullName = Surname;
                if (Name != null && Patronymic != null) fullName += " " + Name[0] + "." + Patronymic[0] + ".";
                return fullName;
            }
        }
        public string FullFullName
        {
            get
            {
                return Surname + " " + Name + " " + Patronymic;
            }
        }
        static public Student Parse(object obj)
        {
            return (Student)obj;
        }
        public delegate void ChangeDataHandelr();
        public event ChangeDataHandelr ChangeDataEvent;
    }

    static class Students
    {

        static public List<Student> Items { get; set; }
        public delegate void ChangeDataInListHandelr();
        public static event ChangeDataInListHandelr ChangeDataInListEvent;
        static public void Load() 
        {
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\students.hav");
            if (File.Exists(path))
            {
                string JSONString;
                FileRead JSONRead = new FileRead();
            
                JSONString = JSONRead.GetJSONString(path);
                StudentCollection studentCollection = JsonConvert.DeserializeObject<StudentCollection>(JSONString);
                Items = studentCollection.Students;
                Items.ForEach(student =>
                {
                    student.ChangeDataEvent += () =>
                    {
                        ChangeDataInListEvent?.Invoke();
                    };
                });
            }
            else
            {
                Save();
                Load();
            }
            Program.SelectUser = selUser;
        }
        static public void Save()
        {
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\students.hav"); 
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "data");
            if (!File.Exists(path))
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                FileStream fs = File.Create(path);
                fs.Close();
            }
            StudentCollection studentCollection = new StudentCollection
            {
                Students = Items ?? new List<Student>()
            };  
            string JSONString = JsonConvert.SerializeObject(studentCollection);
            FileRead JSONRead = new FileRead();
            
            JSONRead.SaveJSONString(path, JSONString);
            Program.SelectUser = selUser;
        }
        static public Student GetStudentByID(int id)
        {
            foreach (Student student in Items)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
        static public bool Extant(int id)
        {
            foreach (Student student in Items)
            {
                if (student.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        static public bool AddStudent(Group group)
        {
            if (Program.SelectUser.Role < 2)
            {
                Student student = new Student
                {
                    Id_Group = group.Id,
                    Id = GetNextId()
                };
                student.ChangeDataEvent += () =>
                {
                    ChangeDataInListEvent?.Invoke();
                };
                Items.Add(student);
                return true;
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка создания студента");
                return false;
            }
        }
        static public bool DeleteStudent(Student student)
        {
            if (Program.SelectUser.Role < 2)
            {
                Items.Remove(student);
                return true;
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка удаления студента");
                return false;
            }
        }
        static public int GetNextId()
        {
            if (Items.Count > 0)
                return Items.Last().Id + 1;
            else
                return 1;
        }
        
    }
}
