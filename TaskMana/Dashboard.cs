using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMana
{
    public partial class Dashboard : Form
    {
        // User controls
        private MyBoardControl myBoardControl;
        private EditNewTaskControl editNewTaskControl;

        public Dashboard()
        {
            InitializeComponent();
            InitializeCustomControls(); // Load controls manually
        }

        private void InitializeCustomControls()
        {
            // Create instances of the user controls
            myBoardControl = new MyBoardControl();
            editNewTaskControl = new EditNewTaskControl();

            // Dock both controls to fill the form
            myBoardControl.Dock = DockStyle.Fill;
            editNewTaskControl.Dock = DockStyle.Fill;

            // Initially only show the board
            myBoardControl.Visible = true;
            editNewTaskControl.Visible = false;

            // Add to the form
            mainPanel.Controls.Add(myBoardControl);
            mainPanel.Controls.Add(editNewTaskControl);

            // Subscribe to TaskClicked event
            HookTaskClickEvent();
        }

        private void HookTaskClickEvent()
        {
            // Find all TaskCards inside the board control (simplified)
            foreach (var listControl in myBoardControl.Controls.OfType<ListControl>())
            {
                foreach (var taskCard in listControl.Controls.OfType<TaskCard>())
                {
                    taskCard.TaskClicked += TaskCard_TaskClicked;
                }
            }

            // If your app dynamically adds task cards, you should hook this in the task creation logic instead
        }

        private void TaskCard_TaskClicked(object sender, EventArgs e)
        {
            // Show the edit control
            editNewTaskControl.Visible = true;
            editNewTaskControl.BringToFront();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetBoardName(string boardName)
        {
            // Optionally set the title on MyBoardControl if needed
            myBoardControl.BoardTitle = boardName;
        }

        // Optionally expose a method to return to the board from Edit
        public void ShowBoardControl()
        {
            editNewTaskControl.Visible = false;
            myBoardControl.Visible = true;
            myBoardControl.BringToFront();
        }
    }
}
