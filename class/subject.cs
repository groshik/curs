using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Curs
{
    class SubjectCollection
    {
        public List<Subject> Subjects { get; set; }
    }

    class Subject
    {
        private int id;
        private string title;
        public int Id {
            get
            {
                return id;
            }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    id = value;
                    ChangeDataEvent?.Invoke();
                }                 
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    title = value;
                    ChangeDataEvent?.Invoke();
                }
                    
            }
        }
        public delegate void ChangeDataHandelr();
        public event ChangeDataHandelr ChangeDataEvent;
    }
    static class Subjects
    {
        static public List<Subject> Items { get; set; }
        public delegate void ChangeDataInListHandelr();
        public static event ChangeDataInListHandelr ChangeDataInListEvent;
        static public void Load()
        {
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\subjects.hav");
            if (File.Exists(path))
            {
                string JSONString;
                FileRead JSONRead = new FileRead();
                
                JSONString = JSONRead.GetJSONString(path);
                SubjectCollection subjectCollection = JsonConvert.DeserializeObject<SubjectCollection>(JSONString);
                Items = subjectCollection.Subjects;
                Items.ForEach(subject =>
                {
                    subject.ChangeDataEvent += () =>
                    {
                        ChangeDataInListEvent?.Invoke();
                    };
                });
            }
            else {
                Save();
                Load();
            }
            Program.SelectUser = selUser;
        }
        static public void Save()
        {
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\subjects.hav");
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
            SubjectCollection subjectCollection = new SubjectCollection
            {
                Subjects = Items ?? new List<Subject>()
            };
            string JSONString = JsonConvert.SerializeObject(subjectCollection);
            FileRead JSONRead = new FileRead();
            
            JSONRead.SaveJSONString(path, JSONString);
            Program.SelectUser = selUser;
        }
        static public Subject GetSubjectByID(int id)
        {
            foreach (Subject subject in Items)
            {
                if (subject.Id == id)
                {
                    return subject;
                }
            }
            return null;
        }
        static public bool Extant(int id)
        {
            foreach (Subject subject in Items)
            {
                if (subject.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        static public bool AddSubject()
        {
            if (Program.SelectUser.Role < 2)
            {
                Subject subject = new Subject
                {
                    Id = Students.GetNextId()
                };
                subject.ChangeDataEvent += () =>
                {
                    ChangeDataInListEvent?.Invoke();
                };
                Items.Add(subject);
                return true;
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка создания предмета");
                return false;
            }
        }

        static public bool DeleteStudent(Subject subject)
        {
            if (Program.SelectUser.Role < 2)
            {
                Items.Remove(subject);
                return true;
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка удаления предмета");
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
