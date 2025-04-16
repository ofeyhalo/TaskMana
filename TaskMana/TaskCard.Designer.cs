namespace TaskMana
{
    partial class TaskCard
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
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.btnTaskSelect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.Location = new System.Drawing.Point(29, 13);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(49, 20);
            this.lblTaskTitle.TabIndex = 0;
            this.lblTaskTitle.Text = "label1";
            // 
            // btnTaskSelect
            // 
            this.btnTaskSelect.AutoSize = true;
            this.btnTaskSelect.Location = new System.Drawing.Point(9, 17);
            this.btnTaskSelect.Name = "btnTaskSelect";
            this.btnTaskSelect.Size = new System.Drawing.Size(14, 13);
            this.btnTaskSelect.TabIndex = 1;
            this.btnTaskSelect.TabStop = true;
            this.btnTaskSelect.UseVisualStyleBackColor = true;
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTaskSelect);
            this.Controls.Add(this.lblTaskTitle);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(249, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.RadioButton btnTaskSelect;
    }
}
