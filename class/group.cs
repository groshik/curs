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
        public int Id { get; set; }

        public string Number { get; set; }
        public string Curator { get; set; }

    }
    static class Groups
    {
        static public List<Group> Items { get; set; }

        static public void Load()
        {
            string JSONString;
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.hav");
            JSONString = JSONRead.GetJSONString(path);
            GroupCollection groupCollection = JsonConvert.DeserializeObject<GroupCollection>(JSONString);
            Items = groupCollection.Groups;
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
            foreach (Group group in Items)
            {
                if (group.Id == id)
                {
                    return group;
                }
            }
            return null;
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
