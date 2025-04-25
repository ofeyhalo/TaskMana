using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskMana.Data; // Ensure this matches the namespace of DatabaseHelper

namespace TaskMana
{
    public partial class MyBoardControl : UserControl
    {
        public string BoardTitle
        {
            get { return lblBoardTitle.Text; }
            set { lblBoardTitle.Text = value; }
        }

        public int BoardId { get; set; } = 1; // Default to 1, or set it externally

        public MyBoardControl()
        {
            InitializeComponent();
            this.Load += MyBoardControl_Load;
        }

        private void MyBoardControl_Load(object sender, EventArgs e)
        {
            LoadListsFromDatabase(BoardId);
        }

        private void LoadListsFromDatabase(int boardId)
        {
            flpBoard.Controls.Clear(); // Clear any existing controls

            string query = $"SELECT ListId, ListTitle FROM Lists WHERE BoardId = {boardId} ORDER BY SortOrder";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                string listTitle = row["ListTitle"].ToString();
                int listId = Convert.ToInt32(row["ListId"]);

                ListControl listControl = new ListControl();
                listControl.ListTitle = listTitle;
                listControl.Width = 250;
                listControl.Tag = listId; // Store listId for future use (e.g. loading tasks)

                Panel listPanel = new Panel();
                listPanel.Width = 260;
                listPanel.Height = listControl.Height;
                listControl.Dock = DockStyle.Fill;

                listPanel.Controls.Add(listControl);
                flpBoard.Controls.Add(listPanel);
            }

            // Re-add the final Add List panel
            flpBoard.Controls.Add(CreateAddListPanel());
        }

        private Panel CreateAddListPanel()
        {
            Panel addListPanel = new Panel();
            addListPanel.Width = 250;
            addListPanel.Height = 300; // Adjust as needed

            btnAddList.Dock = DockStyle.Fill;
            btnAddList.Visible = true;

            addListPanel.Controls.Add(btnAddList);
            return addListPanel;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            Panel containerPanel = (Panel)btnAddList.Parent;
            btnAddList.Visible = false;

            AddAnthrListControl addListControl = new AddAnthrListControl();
            addListControl.Dock = DockStyle.Fill;

            containerPanel.Controls.Add(addListControl);
            addListControl.BringToFront();

            addListControl.CancelClicked += (s, ev) =>
            {
                containerPanel.Controls.Remove(addListControl);
                btnAddList.Visible = true;
            };

            addListControl.ListAdded += (s, listTitle) =>
            {
                // Insert list into DB
                string insertQuery = $"INSERT INTO Lists (BoardId, ListTitle) VALUES ({BoardId}, '{listTitle.Replace("'", "''")}')";
                int result = Data.DatabaseHelper.ExecuteNonQuery(insertQuery);

                if (result > 0)
                {
                    // Reload the lists to reflect the newly added one
                    flpBoard.Controls.Clear();
                    AddAddListButton(); // recreate the last "Add List" panel
                    LoadListsForBoard(BoardId);
                }
                else
                {
                    MessageBox.Show("Failed to create list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

        }

        private void LoadListsForBoard(int boardId)
        {
            string query = $"SELECT ListId, ListTitle FROM Lists WHERE BoardId = {boardId} ORDER BY SortOrder";
            var dt = Data.DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int listId = Convert.ToInt32(row["ListId"]);
                string listTitle = row["ListTitle"].ToString();

                // Create new ListControl
                ListControl listControl = new ListControl();
                listControl.ListTitle = listTitle;
                listControl.ListId = listId;
                listControl.Width = 250;

                // Wrap in a panel
                Panel listPanel = new Panel();
                listPanel.Width = 250;
                listPanel.Height = listControl.Height;
                listControl.Dock = DockStyle.Fill;
                listPanel.Controls.Add(listControl);

                // Insert before "Add Another List" panel
                int addListIndex = flpBoard.Controls.Count - 1;
                flpBoard.Controls.Add(listPanel);
                flpBoard.Controls.SetChildIndex(listPanel, addListIndex);
            }
        }

        private void AddAddListButton()
        {
            // Clear any existing Add List panels
            var existingAddButtonPanel = flpBoard.Controls
                .OfType<Panel>()
                .FirstOrDefault(p => p.Controls.Contains(btnAddList));

            if (existingAddButtonPanel != null)
                flpBoard.Controls.Remove(existingAddButtonPanel);

            // Create a new panel for the Add button
            Panel addListPanel = new Panel
            {
                Width = 250,
                Height = 50
            };

            btnAddList.Dock = DockStyle.Fill;
            addListPanel.Controls.Add(btnAddList);

            flpBoard.Controls.Add(addListPanel);
        }


    }
}
