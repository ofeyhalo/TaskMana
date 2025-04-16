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


        public Dashboard()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetBoardName(string boardName)
        {
            myBoardControl1.BoardTitle = boardName; // Assuming the user control is named boardActivityControl1
        }

    }
}
