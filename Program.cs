using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
             
            string JSONString;
            FileRead JSONRead = new FileRead();

            Students.Load();
            Groups.Load();
            Subjects.Load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
