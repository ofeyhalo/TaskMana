using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TaskMana
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 350;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label lblText = new Label() { Left = 20, Top = 20, Text = text };
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 280 };
            Button btnOk = new Button() { Text = "OK", Left = 220, Width = 80, Top = 80 };
            btnOk.DialogResult = DialogResult.OK;

            prompt.Controls.Add(lblText);
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnOk);
            prompt.AcceptButton = btnOk;

            return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
        }
    }
}
