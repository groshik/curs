using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Curs
{
    class SubjectCollection
    {
        public List<Subject> Subjects { get; set; }
    }

    class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
    static class Subjects
    {
        static public List<Subject> Items { get; set; }

        static public void Load()
        {
            string JSONString;
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\subjects.hav");
            JSONString = JSONRead.GetJSONString(path);
            SubjectCollection subjectCollection = JsonConvert.DeserializeObject<SubjectCollection>(JSONString);
            Items = subjectCollection.Subjects;
        }
        static public void Save()
        {
            SubjectCollection subjectCollection = new SubjectCollection
            {
                Subjects = Items
            };
            string JSONString = JsonConvert.SerializeObject(subjectCollection);
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\subjects.hav");
            JSONRead.SaveJSONString(path, JSONString);
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
        static public void AddSubject()
        {
            Subject subject = new Subject
            {
                Id = Students.GetNextId()
            };
            Items.Add(subject);
        }

        static public void DeleteStudent(Subject subject)
        {
            Items.Remove(subject);
        }
        static public int GetNextId()
        {
            return ++Items.Last().Id;
        }
    }
}
