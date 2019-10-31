using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Curs
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
           
            InitializeComponent();
            groupComboBox1.DataSource = Groups.Items;
            groupComboBox1.DisplayMember = "Number";
            groupComboBox1.ValueMember = "Id";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            

        }
        private void StudentsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            new StudentForm(this).Show();
#pragma warning restore IDE0067
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            new GroupForm(this).Show();
#pragma warning restore IDE0067
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
#pragma warning disable IDE0067
            new SubjectForm(this).Show();
#pragma warning restore IDE0067
        }
    }
}
