using System;
using System.Windows.Forms;

namespace TaskMana
{
    public partial class AddTaskCard : UserControl
    {
        public string TaskTitle
        {
            get { return txtTaskTitle.Text; } // Assuming you use a TextBox
            set { txtTaskTitle.Text = value; }
        }

        public event Action<string> TaskAdded;
        public event EventHandler CancelClicked;

        public AddTaskCard()
        {
            InitializeComponent();
            btnAddTask.Click += btnAddTask_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskTitle))
            {
                if (TaskAdded != null)
                    TaskAdded(TaskTitle);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelClicked != null)
                CancelClicked(this, EventArgs.Empty);
        }
    }
}
