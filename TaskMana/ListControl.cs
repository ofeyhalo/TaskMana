using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskMana
{
    public partial class ListControl : UserControl
    {
        public event Action<string> TaskAdded;

        public string ListTitle
        {
            get { return listTitleLabel.Text; }
            set { listTitleLabel.Text = value; }
        }

        public ListControl()
        {
            InitializeComponent();
            btnAddTask.Click += btnAddTask_Click;
            this.Load += ListControl_Load;
        }

        private void ListControl_Load(object sender, EventArgs e)
        {
            flpTasks.Visible = true; // Hide task list initially
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Ensure the task list is visible
            flpTasks.Visible = true;

            // Hide the "Add Task" button panel
            panelAddTaskButton.Visible = false;

            // ✅ Remove any existing AddTaskCard
            AddTaskCard existingInput = null;
            foreach (Control ctrl in flpTasks.Controls)
            {
                if (ctrl is AddTaskCard)
                {
                    existingInput = (AddTaskCard)ctrl;
                    break;
                }
            }

            if (existingInput != null)
            {
                flpTasks.Controls.Remove(existingInput);
                existingInput.Dispose();
            }

            // ✅ Create one new AddTaskCard
            AddTaskCard taskCard = new AddTaskCard();
            flpTasks.Controls.Add(taskCard);

            // TaskAdded Event
            taskCard.TaskAdded += (taskTitle) =>
            {
                // Create new TaskCard
                TaskCard taskDisplay = new TaskCard();
                taskDisplay.TaskTitle = taskTitle;

                // Replace the input card with the task display
                flpTasks.Controls.Remove(taskCard);
                flpTasks.Controls.Add(taskDisplay);

                panelAddTaskButton.Visible = true;
            };


            // CancelClicked Event
            taskCard.CancelClicked += (s, eArgs) =>
            {
                flpTasks.Controls.Remove(taskCard);
                taskCard.Dispose();

                bool hasTasks = false;
                foreach (Control ctrl in flpTasks.Controls)
                {
                    if (ctrl is TaskCard)
                    {
                        hasTasks = true;
                        break;
                    }
                }

                flpTasks.Visible = hasTasks;
                panelAddTaskButton.Visible = true;
            };
        }

    }
}
