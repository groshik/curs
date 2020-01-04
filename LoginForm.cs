using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Curs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void VisitorRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Visible = false;//Коммент
        }
    }
}
