namespace Planner.UI
{
    partial class TaskForm
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
            this.lblTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(41, 16);
            this.lblTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(45, 20);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task";
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(41, 43);
            this.txtTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(579, 26);
            this.txtTask.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(41, 116);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(579, 74);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(41, 89);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(41, 210);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(62, 20);
            this.lblPriority.TabIndex = 4;
            this.lblPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(41, 235);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(579, 26);
            this.cmbPriority.TabIndex = 3;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.Location = new System.Drawing.Point(187, 421);
            this.btnSaveTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(139, 52);
            this.btnSaveTask.TabIndex = 5;
            this.btnSaveTask.Text = "Save Task";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(360, 421);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveTask);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTask);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}