namespace TaskMana
{
    partial class ListControl
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
            this.listTitleLabel = new System.Windows.Forms.Label();
            this.flpTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.panelAddTaskButton = new System.Windows.Forms.Panel();
            this.taskListTitlePanel = new System.Windows.Forms.Panel();
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.panelAddTaskButton.SuspendLayout();
            this.taskListTitlePanel.SuspendLayout();
            this.taskListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTitleLabel
            // 
            this.listTitleLabel.AutoSize = true;
            this.listTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.listTitleLabel.Name = "listTitleLabel";
            this.listTitleLabel.Size = new System.Drawing.Size(0, 13);
            this.listTitleLabel.TabIndex = 0;
            // 
            // flpTasks
            // 
            this.flpTasks.AutoSize = true;
            this.flpTasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTasks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTasks.Location = new System.Drawing.Point(0, 0);
            this.flpTasks.Name = "flpTasks";
            this.flpTasks.Size = new System.Drawing.Size(249, 94);
            this.flpTasks.TabIndex = 1;
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddTask.Image = global::TaskMana.Properties.Resources.grey_plus_math_24px;
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.Location = new System.Drawing.Point(3, 5);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(243, 32);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add a Task";
            this.btnAddTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // panelAddTaskButton
            // 
            this.panelAddTaskButton.AutoSize = true;
            this.panelAddTaskButton.Controls.Add(this.btnAddTask);
            this.panelAddTaskButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddTaskButton.Location = new System.Drawing.Point(0, 127);
            this.panelAddTaskButton.Name = "panelAddTaskButton";
            this.panelAddTaskButton.Size = new System.Drawing.Size(249, 40);
            this.panelAddTaskButton.TabIndex = 3;
            // 
            // taskListTitlePanel
            // 
            this.taskListTitlePanel.Controls.Add(this.listTitleLabel);
            this.taskListTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskListTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.taskListTitlePanel.Name = "taskListTitlePanel";
            this.taskListTitlePanel.Size = new System.Drawing.Size(249, 33);
            this.taskListTitlePanel.TabIndex = 4;
            // 
            // taskListPanel
            // 
            this.taskListPanel.Controls.Add(this.flpTasks);
            this.taskListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListPanel.Location = new System.Drawing.Point(0, 33);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(249, 94);
            this.taskListPanel.TabIndex = 5;
            // 
            // ListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.taskListPanel);
            this.Controls.Add(this.taskListTitlePanel);
            this.Controls.Add(this.panelAddTaskButton);
            this.Name = "ListControl";
            this.Size = new System.Drawing.Size(249, 167);
            this.Load += new System.EventHandler(this.ListControl_Load);
            this.panelAddTaskButton.ResumeLayout(false);
            this.taskListTitlePanel.ResumeLayout(false);
            this.taskListTitlePanel.PerformLayout();
            this.taskListPanel.ResumeLayout(false);
            this.taskListPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listTitleLabel;
        public System.Windows.Forms.FlowLayoutPanel flpTasks;
        private System.Windows.Forms.Button btnAddTask;
        public System.Windows.Forms.Panel panelAddTaskButton;
        private System.Windows.Forms.Panel taskListTitlePanel;
        private System.Windows.Forms.Panel taskListPanel;
    }
}
