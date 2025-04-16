using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMana
{
    public partial class TaskCard : UserControl
    {

        public string TaskTitle
        {
            get { return lblTaskTitle.Text; }
            set { lblTaskTitle.Text = value; }
        }

        public TaskCard()
        {
            InitializeComponent();
        }
    }
}
