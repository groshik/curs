using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Curs
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
   
            InitializeComponent();

            Shown += new EventHandler(WellcomForm_Shown);
            
        }

        public void LoadData()
        {
            
            LoadProgress.Text = "Загрузка данных о студентах...";
            LoadProgress.Refresh();
            Students.Load();
            LoadProgress.Text = "Загрузка данных о группах...";
            LoadProgress.Refresh();
            Application.EnableVisualStyles();
            Groups.Load();
            LoadProgress.Text = "Загрузка данных о предметах...";
            LoadProgress.Refresh();
            Application.EnableVisualStyles();
            Subjects.Load();
            LoadProgress.Text = "Загрузка пользователей...";
            LoadProgress.Refresh();
            Application.EnableVisualStyles();
            Users.Load();
            LoadProgress.Text = "Загрузка завершина...";
            LoadProgress.Refresh();
            Thread.Sleep(1500);
            DialogResult = DialogResult.OK;
        }
        

        private void WellcomForm_Shown(object sender, EventArgs e)
        {
            Refresh();
            LoadData();
        }


    }
}
