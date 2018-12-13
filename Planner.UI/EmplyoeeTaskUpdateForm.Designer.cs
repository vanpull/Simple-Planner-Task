namespace Planner.UI
{
    partial class EmplyoeeTaskUpdateForm
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
            this.lblTaskValue = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdoClosed = new System.Windows.Forms.RadioButton();
            this.rdoProgress = new System.Windows.Forms.RadioButton();
            this.lblActualTime = new System.Windows.Forms.Label();
            this.txtActualTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(19, 21);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(51, 17);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task : ";
            // 
            // lblTaskValue
            // 
            this.lblTaskValue.AutoSize = true;
            this.lblTaskValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskValue.Location = new System.Drawing.Point(73, 21);
            this.lblTaskValue.Name = "lblTaskValue";
            this.lblTaskValue.Size = new System.Drawing.Size(39, 17);
            this.lblTaskValue.TabIndex = 1;
            this.lblTaskValue.Text = "Task";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionValue.Location = new System.Drawing.Point(112, 50);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(39, 17);
            this.lblDescriptionValue.TabIndex = 3;
            this.lblDescriptionValue.Text = "Task";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(19, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description : ";
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.Location = new System.Drawing.Point(61, 258);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(127, 34);
            this.btnUpdateTask.TabIndex = 10;
            this.btnUpdateTask.Text = "Update Task";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(208, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdoClosed);
            this.grpStatus.Controls.Add(this.rdoProgress);
            this.grpStatus.Location = new System.Drawing.Point(22, 168);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(349, 59);
            this.grpStatus.TabIndex = 12;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Task Status";
            // 
            // rdoClosed
            // 
            this.rdoClosed.AutoSize = true;
            this.rdoClosed.Location = new System.Drawing.Point(261, 24);
            this.rdoClosed.Name = "rdoClosed";
            this.rdoClosed.Size = new System.Drawing.Size(57, 17);
            this.rdoClosed.TabIndex = 5;
            this.rdoClosed.TabStop = true;
            this.rdoClosed.Tag = "5";
            this.rdoClosed.Text = "Closed";
            this.rdoClosed.UseVisualStyleBackColor = true;
            // 
            // rdoProgress
            // 
            this.rdoProgress.AutoSize = true;
            this.rdoProgress.Location = new System.Drawing.Point(13, 25);
            this.rdoProgress.Name = "rdoProgress";
            this.rdoProgress.Size = new System.Drawing.Size(75, 17);
            this.rdoProgress.TabIndex = 0;
            this.rdoProgress.TabStop = true;
            this.rdoProgress.Tag = "2";
            this.rdoProgress.Text = "InProgress";
            this.rdoProgress.UseVisualStyleBackColor = true;
            // 
            // lblActualTime
            // 
            this.lblActualTime.AutoSize = true;
            this.lblActualTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualTime.Location = new System.Drawing.Point(19, 94);
            this.lblActualTime.Name = "lblActualTime";
            this.lblActualTime.Size = new System.Drawing.Size(149, 17);
            this.lblActualTime.TabIndex = 13;
            this.lblActualTime.Text = "Actual Time (in Hours)";
            // 
            // txtActualTime
            // 
            this.txtActualTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualTime.Location = new System.Drawing.Point(22, 114);
            this.txtActualTime.MaxLength = 3;
            this.txtActualTime.Name = "txtActualTime";
            this.txtActualTime.Size = new System.Drawing.Size(349, 23);
            this.txtActualTime.TabIndex = 14;
            // 
            // EmplyoeeTaskUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 330);
            this.Controls.Add(this.txtActualTime);
            this.Controls.Add(this.lblActualTime);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lblDescriptionValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTaskValue);
            this.Controls.Add(this.lblTask);
            this.MaximizeBox = false;
            this.Name = "EmplyoeeTaskUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmplyoeeTaskUpdateForm";
            this.Load += new System.EventHandler(this.EmplyoeeTaskUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblTaskValue;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdoProgress;
        private System.Windows.Forms.RadioButton rdoClosed;
        private System.Windows.Forms.Label lblActualTime;
        private System.Windows.Forms.TextBox txtActualTime;
    }
}