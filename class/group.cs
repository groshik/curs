using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Curs
{
    class GroupCollection
    {
        private List<Group> groups;
        public List<Group> Groups
        {
            get
            {
                return groups;
            }
            set
            {
                groups = value;
            }
        }
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
            }
        }

    }
    static class Groups
    {
        static private List<Group> items;
        static public List<Group> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        static public void Load()
        {
            string JSONString;
            FileRead JSONRead = new FileRead();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.json");
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
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.json");
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
            // test commit
        }
    }
}
