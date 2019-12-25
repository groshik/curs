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
            //JSONRead.EncriptFile(Path.Combine(Directory.GetCurrentDirectory(), "data\\grades.hav"));
            //JSONRead.DecryptFile(Path.Combine(Directory.GetCurrentDirectory(), "data\\grades.hav"));

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
    }

}
