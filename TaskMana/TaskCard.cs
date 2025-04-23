using System;
using System.Windows.Forms;

namespace TaskMana
{
    public partial class TaskCard : UserControl
    {
        // Event to notify when this card is clicked
        public event EventHandler TaskClicked;

        public string TaskTitle
        {
            get { return lblTaskTitle.Text; }
            set { lblTaskTitle.Text = value; }
        }

        public TaskCard()
        {
            InitializeComponent();
            this.Click += TaskCard_Click; // Hook up click event on the control
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += TaskCard_Click; // Also hook child controls
            }
        }

        private void TaskCard_Click(object sender, EventArgs e)
        {
            // Raise the event to notify listeners
            if (TaskClicked != null)
                TaskClicked(this, EventArgs.Empty);
        }

        private void TaskCard_Load(object sender, EventArgs e)
        {
            // Optional: Put any logic here you want to run when TaskCard loads.
        }


    }
}
