using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Curs
{
    class GroupCollection
    {
        public List<Group> Groups { get; set; }
    }

    class Group
    {
        public Group()
        {

        }
        public Group(int Id, string Number)
        {
            id = Id;
            number = Number;
        }
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
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    id = value;
                    ChangeDataEvent?.Invoke();
                }
                    
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
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    number = value;
                    ChangeDataEvent?.Invoke();
                }
                    
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
                if (Program.SelectUser == null || Program.SelectUser.Role < 2)
                {
                    curator = value;
                    ChangeDataEvent?.Invoke();
                }
                    
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
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.hav");
            if (File.Exists(path))
            {
                string JSONString;
                FileRead JSONRead = new FileRead();
            
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
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\groups.hav");
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
            GroupCollection groupCollection = new GroupCollection
            {
                Groups = Items ?? new List<Group>()
            };
            string JSONString = JsonConvert.SerializeObject(groupCollection);
            FileRead JSONRead = new FileRead();
            JSONRead.SaveJSONString(path, JSONString);
            Program.SelectUser = selUser;
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
            Group noGroup = new Group
            {
                Id = 0,
                Number = "Нет группы"
            };
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
        static public bool AddGroup()
        {
            if (Program.SelectUser.Role < 2)
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
                return true;
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка создания группы");
                return false;
            }
        }

        static public bool DeleteGrop(Group group)
        {
            if (Program.SelectUser.Role < 2)
            {
                Items.Remove(group);
                return true;
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка удаления группы");
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
