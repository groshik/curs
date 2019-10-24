using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Id_Group { get; set; }

    }

    static class Students
    {

        static public List<Student> Items { get; set; }

        static public void Load() {
            string JSONString;
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\students.json");
            JSONString = JSONRead.GetJSONString(path);
            StudentCollection studentCollection = JsonConvert.DeserializeObject<StudentCollection>(JSONString);
            Items = studentCollection.Students;
        }
        static public void Save()
        {
            StudentCollection studentCollection = new StudentCollection
            {
                Students = Items
            };  
            string JSONString = JsonConvert.SerializeObject(studentCollection);
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\students.json");
            JSONRead.SaveJSONString(path, JSONString);
        }
        static public Student GetItemByID(int id)
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
                Id = Students.GetNextId()
            };
            Items.Add(student);
        }

        static public void DeleteStudent(Student student)
        {
            Items.Remove(student);
        }

        static public int GetNextId()
        {
            return ++Items.Last().Id;
        }
    }
}
