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
    public partial class AddAnthrListControl : UserControl
    {
        public delegate void ListAddedHandler(string listName, int listId);
        public event EventHandler<(string listName, int listId)> ListAdded;
        public event EventHandler CancelClicked;

        private string placeholderText = "Enter list title...";
        public int BoardId { get; set; } // Set this from MyBoardControl

        public AddAnthrListControl()
        {
            InitializeComponent();
            txtListName.Text = placeholderText;
            txtListName.ForeColor = Color.Gray;

            // Attach placeholder logic events
            txtListName.Enter += txtListName_Enter;
            txtListName.Leave += txtListName_Leave;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtListName.Text) && txtListName.Text != placeholderText)
            {
                string listTitle = txtListName.Text.Trim();
                string insertQuery = $"INSERT INTO Lists (BoardId, ListTitle) OUTPUT INSERTED.ListId VALUES ({BoardId}, '{listTitle.Replace("'", "''")}')";

                object result = Data.DatabaseHelper.ExecuteScalar(insertQuery);
                if (result != null && int.TryParse(result.ToString(), out int listId))
                {
                    ListAdded?.Invoke(this, (listTitle, listId));
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to save list to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        private void txtListName_Enter(object sender, EventArgs e)
        {
            if (txtListName.Text == placeholderText)
            {
                txtListName.Text = "";
                txtListName.ForeColor = Color.Black;
            }
        }

        private void txtListName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtListName.Text))
            {
                txtListName.Text = placeholderText;
                txtListName.ForeColor = Color.Gray;
            }
        }
    }
}