namespace TaskMana
{
    partial class AddAnthrListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtListName = new System.Windows.Forms.TextBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtListName
            // 
            this.txtListName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtListName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListName.Location = new System.Drawing.Point(11, 9);
            this.txtListName.MaxLength = 50;
            this.txtListName.Multiline = true;
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(219, 36);
            this.txtListName.TabIndex = 0;
            this.txtListName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtListName.WordWrap = false;
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnAddList.FlatAppearance.BorderSize = 0;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Location = new System.Drawing.Point(9, 51);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(78, 30);
            this.btnAddList.TabIndex = 1;
            this.btnAddList.Text = "Add list";
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::TaskMana.Properties.Resources.delete_24px;
            this.btnCancel.Location = new System.Drawing.Point(95, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddAnthrListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.txtListName);
            this.Name = "AddAnthrListControl";
            this.Size = new System.Drawing.Size(242, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnCancel;

    }
}
