using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Curs
{

    static class Program
    {
        [STAThread]
        static void Main()
        {       
            Students.Load();
            Groups.Load();
            Subjects.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
    }

}
