namespace Planner.UI
{
    partial class AssignTaskForm
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
            this.components = new System.ComponentModel.Container();
            this.txtEstimatedEffort = new System.Windows.Forms.TextBox();
            this.lblEffortEstimate = new System.Windows.Forms.Label();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.cmdEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstimatedEffort
            // 
            this.txtEstimatedEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimatedEffort.Location = new System.Drawing.Point(35, 276);
            this.txtEstimatedEffort.MaxLength = 3;
            this.txtEstimatedEffort.Name = "txtEstimatedEffort";
            this.txtEstimatedEffort.Size = new System.Drawing.Size(435, 23);
            this.txtEstimatedEffort.TabIndex = 8;
            this.txtEstimatedEffort.TextChanged += new System.EventHandler(this.txtEstimatedEffort_TextChanged);
            this.txtEstimatedEffort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstimatedEffort_KeyPress);
            // 
            // lblEffortEstimate
            // 
            this.lblEffortEstimate.AutoSize = true;
            this.lblEffortEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffortEstimate.Location = new System.Drawing.Point(35, 254);
            this.lblEffortEstimate.Name = "lblEffortEstimate";
            this.lblEffortEstimate.Size = new System.Drawing.Size(175, 17);
            this.lblEffortEstimate.TabIndex = 9;
            this.lblEffortEstimate.Text = "Estimated Effort (in Hours)";
            this.lblEffortEstimate.Click += new System.EventHandler(this.lblEffortEstimate_Click);
            // 
            // cmbTask
            // 
            this.cmbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(31, 45);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(435, 23);
            this.cmbTask.TabIndex = 10;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(31, 25);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(39, 17);
            this.lblTask.TabIndex = 11;
            this.lblTask.Text = "Task";
            // 
            // cmdEmployee
            // 
            this.cmdEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEmployee.FormattingEnabled = true;
            this.cmdEmployee.Location = new System.Drawing.Point(31, 119);
            this.cmdEmployee.Name = "cmdEmployee";
            this.cmdEmployee.Size = new System.Drawing.Size(435, 23);
            this.cmdEmployee.TabIndex = 12;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(31, 99);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(70, 17);
            this.lblEmployee.TabIndex = 13;
            this.lblEmployee.Text = "Employee";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(265, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTask.Location = new System.Drawing.Point(135, 323);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(104, 42);
            this.btnAssignTask.TabIndex = 14;
            this.btnAssignTask.Text = "Assign Task";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(28, 177);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(107, 17);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Task Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(31, 197);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(276, 23);
            this.dtpStartDate.TabIndex = 16;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // AssignTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 403);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssignTask);
            this.Controls.Add(this.cmdEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbTask);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.txtEstimatedEffort);
            this.Controls.Add(this.lblEffortEstimate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstimatedEffort;
        private System.Windows.Forms.Label lblEffortEstimate;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.ComboBox cmdEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}