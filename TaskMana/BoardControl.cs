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
    public partial class BoardControl : UserControl
    {

        private Label lblBoardName;

        // Property to get/set the board name
        public string BoardName
        {
            get { return lblBoardName.Text; }
            set { lblBoardName.Text = value; }
        }


        public BoardControl()
        {
            InitializeComponent();

            this.Click += new EventHandler(pnlNewBoard_Click);
            pnlNewBoard.Click += new EventHandler(pnlNewBoard_Click);

            //initialize label inside the constructor
            lblBoardName = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12)
            };

            this.Controls.Add(lblBoardName);
        }

                    

            private void BoardControl_Click(object sender, EventArgs e)
            {
                
            }

            private void pnlNewBoard_Click(object sender, EventArgs e)
            {
                Dashboard dashboard = new Dashboard();
                //dashboard.BoardName = this.BoardName; // Pass board name
                dashboard.Show();
            }

        }



}
