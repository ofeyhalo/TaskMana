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

        // Event to notify parent that this task was clicked
        public event EventHandler TaskClicked;

        public TaskCard()
        {
            InitializeComponent();

            // Hook up the click event
            this.Click += TaskCard_Click;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += TaskCard_Click;
            }
        }

        private void TaskCard_Click(object sender, EventArgs e)
        {
            // Raise the custom event
            if (this.TaskClicked != null)
            {
                TaskClicked(this, EventArgs.Empty);
            }
        }

        private void TaskCard_Load(object sender, EventArgs e)
        {
        }
    }
}
