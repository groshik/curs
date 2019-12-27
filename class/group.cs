using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Curs
{
    class GroupCollection
    {
        public List<Group> Groups { get; set; }
    }

    class Group
    {
        private int id;
        private string number;
        private string curator;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public string Curator
        {
            get
            {
                return curator;
            }
            set
            {
                curator = value;
                ChangeDataEvent?.Invoke();
            }
        }
        public delegate void ChangeDataHandelr();
        public event ChangeDataHandelr ChangeDataEvent;
    }
    static class Groups
    {
        static public List<Group> Items { get; set; }
        public delegate void ChangeDataInListHandelr();
        public static event ChangeDataInListHandelr ChangeDataInListEvent;
        static public void Load()
        {
            string JSONString;
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.hav");
            JSONString = JSONRead.GetJSONString(path);
            GroupCollection groupCollection = JsonConvert.DeserializeObject<GroupCollection>(JSONString);
            Items = groupCollection.Groups;
            Items.ForEach(group =>
            {
                group.ChangeDataEvent += () =>
                {
                    ChangeDataInListEvent?.Invoke();
                };
            });
        }
        static public void Save()
        {
            GroupCollection groupCollection = new GroupCollection
            {
                Groups = Items
            };
            string JSONString = JsonConvert.SerializeObject(groupCollection);
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.hav");
            JSONRead.SaveJSONString(path, JSONString);
        }
        static public Group GetGroupByID(int id)
        {
            if (Items != null)
            foreach (Group group in Items)
            {
                if (group.Id == id)
                {
                    return group;
                }
            }
            Group noGroup = new Group();
            noGroup.Id = 0;
            noGroup.Number = "Нет группы";
            return noGroup;
        }
        static public bool Extant(int id)
        {
            foreach (Group group in Items)
            {
                if (group.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        static public void AddGroup()
        {
            Group group = new Group
            {
                Id = Students.GetNextId()
            };
            group.ChangeDataEvent += () =>
            {
                ChangeDataInListEvent?.Invoke();
            };
            Items.Add(group);
        }

        static public void DeleteStudent(Group group)
        {
            Items.Remove(group);
        }
        static public int GetNextId()
        {
            return ++Items.Last().Id;
        }
    }
}
