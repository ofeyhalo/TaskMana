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
    public partial class AddAnthrListControl : UserControl
    {
        public delegate void ListAddedHandler(string listName);
        public event EventHandler<string> ListAdded;
        public event EventHandler CancelClicked;

        private string placeholderText = "Enter list title...";

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
                if (ListAdded != null)
                    ListAdded(this, txtListName.Text); // Notify subscribers

                this.Dispose(); // Close the input panel after adding the list
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelClicked != null)
                CancelClicked(this, EventArgs.Empty); // Notify cancellation

            this.Dispose(); // Remove the input panel
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
