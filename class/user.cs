using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Curs
{
    class UsertCollection
    {
        public List<User> Users = new List<User>();
    }
    public class User
    {
        private string login;
        private string pass;
        private int role;
        public User()
        {
            role = 2;
        }
        public User(string Login, string Pass)
        {
            login = Login;
            pass = Pass;
            role = 2;
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (Program.SelectUser == null)
                {
                    login = value;
                    ChangeDataEvent?.Invoke();
                }
            }
        }
        public string Pass
        {
            get
            {
                if (Program.SelectUser == null || Program.SelectUser.Role == 0 || Program.SelectUser == this)
                    return pass;
                else
                    return "Нет доступа";
            }
            set
            {
                if (Program.SelectUser == null || Program.SelectUser.Role == 0 || Program.SelectUser == this)
                {
                    pass = value;
                    ChangeDataEvent?.Invoke();
                }
            }
        }
        public int Role
        {
            get
            {
                return role;
            }
            set
            {

                if (Program.SelectUser == null || Program.SelectUser.Role < role || Program.SelectUser == this)
                {
                    role = value;
                    ChangeDataEvent?.Invoke();
                }
            }
        }
        public string RoleString 
        {
            get 
            {
                switch (role)
                {
                    case 0:
                        return "root";
                    case 1:
                        return "Администратор";
                    case 2:
                        return "Пользователь";
                }
                return null;
            }
        }
        public delegate void ChangeDataHandelr();
        public event ChangeDataHandelr ChangeDataEvent;
    }
    static class Users
    {
        static public List<User> Items = new List<User>();
        public delegate void ChangeDataInListHandelr();
        public static event ChangeDataInListHandelr ChangeDataInListEvent;
        static public void Load()
        {
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\users.hav");
            if (File.Exists(path))
            {
                string JSONString;
                FileRead JSONRead = new FileRead();
                
                JSONString = JSONRead.GetJSONString(path);
                UsertCollection usertCollection = JsonConvert.DeserializeObject<UsertCollection>(JSONString);
                Items = usertCollection.Users;
                Items.ForEach(user =>
                {
                    user.ChangeDataEvent += () =>
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
            if (selUser != null)
            {
                selUser = Users.GetUser(selUser.Login);
            }
            Program.SelectUser = selUser;
        }
        static public void Save()
        {
            User selUser = Program.SelectUser;
            Program.SelectUser = null;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data\\users.hav");
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
            UsertCollection usertCollection = new UsertCollection
            {
                Users = Items ?? new List<User>()
            };
            string JSONString = JsonConvert.SerializeObject(usertCollection);
            FileRead JSONRead = new FileRead();    
            JSONRead.SaveJSONString(path, JSONString);
            Program.SelectUser = selUser;
        }
        static public bool Extant(string login)
        {
            foreach (User user in Items)
            {
                if (user.Login == login)
                {
                    return true;
                }
            }
            return false;
        }
        static public List<User> GetUsersList()
        {
            List<User> listUser = new List<User>();
            listUser.Add(Program.SelectUser);
            listUser.AddRange(Items.Where(user =>
            {
                if (user.Role > Program.SelectUser.Role)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).ToList());
            return listUser;            
        }
        static public bool AddUser(string login, string pass)
        {
            if (!Users.Extant(login))
            {
                User user = new User(login, pass);
                user.ChangeDataEvent += () =>
                {
                    ChangeDataInListEvent?.Invoke();
                };
                Items.Add(user);
                return true;
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует", "Ошибка создания пользователя");
                return false;
            }
        }
        static public bool DeleteUsert(User user)
        {
            if (Program.SelectUser.Role < 2)
            {
                if (user.Role == 0)
                {
                    MessageBox.Show("Попытка удалить root пользователя", "Ошибка удаления пользователя");
                    return false;
                }
                else
                {
                    if (user == Program.SelectUser)
                    {
                        Items.Remove(user);
                        MessageBox.Show("Вы удалили авторизованного пользователя", "Перезапуск программы");
                        Application.Restart();
                        return true;
                    }
                    if (user.Role == 2)
                    {
                        Items.Remove(user);
                        return true;
                    }
                    else
                    {
                        if (Program.SelectUser.Role == 0)
                        {
                            Items.Remove(user);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("У вас недостаточно Прав", "Ошибка удаления пользователя");
                            return false;
                        }
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("У вас недостаточно Прав", "Ошибка удаления пользователя");
                return false;
            }
        }
        static public User GetUser(string login)
        {
            foreach ( User user in Items)
            {
                if (user.Login == login)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
