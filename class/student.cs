using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

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
                surname = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public int Id_Group
        {
            get { return id_group; }
            set
            {
                id_group = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public bool Paid_Form_Of_Study
        {
            get { return paid_form_of_study; }
            set
            {
                paid_form_of_study = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public bool Active_Participation
        {
            get { return active_participation; }
            set
            {
                active_participation = value;
                ChangeDataEvent?.Invoke();
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
        static public void Load() {
            string JSONString;
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\students.hav");
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
        static public void Save()
        {
            StudentCollection studentCollection = new StudentCollection
            {
                Students = Items
            };  
            string JSONString = JsonConvert.SerializeObject(studentCollection);
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\students.hav");
            JSONRead.SaveJSONString(path, JSONString);
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
        static public void AddStudent(Group group)
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
        }
        static public void DeleteStudent(Student student)
        {
            Items.Remove(student);
        }
        static public int GetNextId()
        {
            return Items.Last().Id + 1;
        }
        
    }
}
