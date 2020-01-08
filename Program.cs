using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace Curs
{

    static class Program
    {
        public static User SelectUser { get; set; }
        [STAThread]
        static void Main()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Newtonsoft.Json.dll");
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Open(path, FileMode.CreateNew))
                {
                    fs.Write(Properties.Resources.Newtonsoft_Json, 0, Properties.Resources.Newtonsoft_Json.Length);
                    fs.Close();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (WelcomeForm wellcom = new WelcomeForm())
            {
                wellcom.ShowDialog();
            }
            if (Users.Items.Count == 0)
            {
                using (CreateAdminForm adminForm = new CreateAdminForm())
                {
                    MessageBox.Show("Список пользователей пуст.\nСоздайте root пользователя", "Настройки программы", MessageBoxButtons.OK);
                    DialogResult resultAdminForm = adminForm.ShowDialog();
                    if (resultAdminForm != DialogResult.OK)
                    {
                        return;
                    }
                    else
                    {
                        Users.Save();
                        SelectUser = adminForm.GetCreateUser();
                    }

                }
            }
            else
            {
                using (LoginForm loginForm = new LoginForm())
                {
                    DialogResult resultLoginForm = loginForm.ShowDialog();
                    if (resultLoginForm != DialogResult.OK)
                    {
                        return;
                    }
                    else
                    {
                        SelectUser = loginForm.GetUser();
                    }

                }
            }
            Application.Run(new MainForm());
            
        }
        public static int CheckString(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return -1;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return 1;
            }
            return 0;
        }
        public static List<int> StringInListInt(string str, char delimiter)
        {
            str = str.Trim(' ');
            List<int> newList = new List<int>();
            string value = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == delimiter)
                {
                    newList.Add(Int32.Parse(value));
                    value = "";
                }
                else
                {
                    value += str[i];
                }
            }
            if (str.Length > 0)
                newList.Add(Int32.Parse(value));
            return newList;
        }
        public static List<string> StringInListString(string str, char delimiter)
        {
            str = str.Trim(' ');
            List<string> newList = new List<string>();
            string value = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == delimiter)
                {
                    newList.Add(value);
                    value = "";
                }
                else
                {
                    value += str[i];
                }
            }
            if (str.Length > 0)
                newList.Add(value);
            return newList;
        }
        public static void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled == false)
            {
                System.Drawing.Brush drawBrush = new SolidBrush(System.Drawing.Color.FromArgb(22, 22, 22));
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                string text = btn.Text;
                e.Graphics.FillRectangle(new SolidBrush(btn.BackColor), e.ClipRectangle);
                e.Graphics.DrawString(text, btn.Font, drawBrush, e.ClipRectangle, sf);
                drawBrush.Dispose();
                sf.Dispose();
            }
        }
    }


}
