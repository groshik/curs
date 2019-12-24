using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs
{
    public partial class DialogAddGroupStudents : Form
    {
        public DialogAddGroupStudents()
        {
            InitializeComponent();
            GroupListBox.DataSource = Groups.Items;
            GroupListBox.DisplayMember = "Number";
            GroupListBox.ValueMember = "Id";
        }
    }
}
