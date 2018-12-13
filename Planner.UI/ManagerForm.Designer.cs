namespace Planner.UI
{
    partial class ManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuDashboard = new System.Windows.Forms.MenuStrip();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAssignTask = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.menuDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDashboard
            // 
            this.menuDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem});
            this.menuDashboard.Location = new System.Drawing.Point(0, 0);
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(784, 24);
            this.menuDashboard.TabIndex = 0;
            this.menuDashboard.Text = "menuStrip1";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewTask,
            this.menuAssignTask});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // menuNewTask
            // 
            this.menuNewTask.Name = "menuNewTask";
            this.menuNewTask.Size = new System.Drawing.Size(132, 22);
            this.menuNewTask.Text = "New Task";
            this.menuNewTask.Click += new System.EventHandler(this.menuNewTask_Click);
            // 
            // menuAssignTask
            // 
            this.menuAssignTask.Name = "menuAssignTask";
            this.menuAssignTask.Size = new System.Drawing.Size(132, 22);
            this.menuAssignTask.Text = "AssignTask";
            this.menuAssignTask.Click += new System.EventHandler(this.menuAssignTask_Click);
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Location = new System.Drawing.Point(6, 19);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.Size = new System.Drawing.Size(748, 497);
            this.dgvTaskList.TabIndex = 1;
            this.dgvTaskList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTaskList_DataBindingComplete);
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.dgvTaskList);
            this.grpTasks.Location = new System.Drawing.Point(12, 27);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(760, 522);
            this.grpTasks.TabIndex = 3;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Tasks";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.menuDashboard);
            this.MainMenuStrip = this.menuDashboard;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Planner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuDashboard.ResumeLayout(false);
            this.menuDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.grpTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuDashboard;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewTask;
        private System.Windows.Forms.DataGridView dgvTaskList;
        private System.Windows.Forms.ToolStripMenuItem menuAssignTask;
        private System.Windows.Forms.GroupBox grpTasks;
    }
}