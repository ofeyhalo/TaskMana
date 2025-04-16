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
    public partial class Main : Form
    {

        private List<BoardControl> boards = new List<BoardControl>(); // Stores created boards


        public Main()
        {
            InitializeComponent();
        }

        private void btnCreateBoard_Click(object sender, EventArgs e)
        {
            // ✅ Open Input Dialog (VS 2013 doesn't support modern InputBox)
            string lblBoardName = Prompt.ShowDialog("Enter Board Name:", "New Board");

            if (string.IsNullOrWhiteSpace(lblBoardName))
            {
                MessageBox.Show("Board name cannot be empty!");
                return;
            }

            // ✅ Create a new BoardPanel instance
            BoardControl newBoard = new BoardControl();
            newBoard.BoardName = lblBoardName;

            // ✅ Add to list & FlowLayoutPanel
            boards.Add(newBoard);
            boardContainer.Controls.Add(newBoard);
            boardContainer.Invalidate();
        }


        
    }
}
