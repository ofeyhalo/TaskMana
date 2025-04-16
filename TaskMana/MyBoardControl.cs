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
    public partial class MyBoardControl : UserControl
    {
        public string BoardTitle
        {
            get { return lblBoardTitle.Text; }
            set { lblBoardTitle.Text = value; }
        }

        public MyBoardControl()
        {
            InitializeComponent();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            // Reference the button's parent panel (inside flpBoard)
            Panel containerPanel = (Panel)btnAddList.Parent;

            // Hide the "Add Another List" button
            btnAddList.Visible = false;

            // Create and set up the AddAnotherList control
            AddAnthrListControl addListControl = new AddAnthrListControl();
            addListControl.Dock = DockStyle.Fill;

            // Add it to the same panel
            containerPanel.Controls.Add(addListControl);
            addListControl.BringToFront();

            // Cancel handler
            addListControl.CancelClicked += (s, ev) =>
            {
                containerPanel.Controls.Remove(addListControl);
                btnAddList.Visible = true;
            };

            // Add list handler
            addListControl.ListAdded += (s, listTitle) =>
            {
                // Create new list
                ListControl newList = new ListControl();
                newList.ListTitle = listTitle;
                newList.Width = 250;

                // Create a wrapper panel for the new list (optional for styling/layout)
                Panel newListPanel = new Panel();
                newListPanel.Width = 250;
                newListPanel.Height = newList.Height;
                newList.Dock = DockStyle.Fill;
                newListPanel.Controls.Add(newList);

                // Insert the new panel before the "Add Another List" button panel
                int addButtonIndex = flpBoard.Controls.IndexOf(containerPanel);
                flpBoard.Controls.Add(newListPanel);
                flpBoard.Controls.SetChildIndex(newListPanel, addButtonIndex);

                // Reset the addList UI
                containerPanel.Controls.Remove(addListControl);
                btnAddList.Visible = true;
            };
        }
    }
}
