namespace Planner.UI
{
    partial class EmployeeForm
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
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.grpTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.dgvTaskList);
            this.grpTasks.Location = new System.Drawing.Point(12, 12);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(760, 537);
            this.grpTasks.TabIndex = 0;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Tasks";
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Location = new System.Drawing.Point(6, 19);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.Size = new System.Drawing.Size(748, 512);
            this.dgvTaskList.TabIndex = 0;
            this.dgvTaskList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellDoubleClick);
            this.dgvTaskList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTaskList_DataBindingComplete);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpTasks);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Planner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeForm_FormClosed);
            this.grpTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.DataGridView dgvTaskList;
    }
}