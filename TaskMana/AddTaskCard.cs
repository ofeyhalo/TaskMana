using System;
using System.Windows.Forms;

namespace TaskMana
{
    public partial class AddTaskCard : UserControl
    {
        public event Action<string> TaskAdded;
        public event EventHandler CancelClicked;

        public AddTaskCard()
        {
            InitializeComponent();

            btnAddTask.Click += BtnAddTask_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            string taskTitle = txtTaskTitle.Text.Trim();

            if (!string.IsNullOrEmpty(taskTitle))
            {
                TaskAdded?.Invoke(taskTitle); // ✅ Only send the typed title
            }
            else
            {
                MessageBox.Show("Please enter a task title.", "Empty Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
