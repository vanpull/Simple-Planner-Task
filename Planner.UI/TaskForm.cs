using Planner.Core.Domain;
using Planner.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Planner.UI
{
    public partial class TaskForm : Form
    {
        private CrudService<Task> _taskService;

        public static Employee LoggedInUser { get; set; }

        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        public TaskForm()
        {
            InitializeComponent();
            cmbPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            _taskService = new CrudService<Task>();
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTask.Text))
                {
                    errorProvider.SetError(txtTask, "Please enter task");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtTask, "");
                }

                

                TaskPriority priority = (TaskPriority)cmbPriority.SelectedItem;

                var task = new Task()
                {
                    Name = txtTask.Text,
                    Description = txtDescription.Text,
                    Priority = (int)priority,
                    CreatedOn = DateTime.Now                    
                };

                _taskService.Add(task);

                

                MessageBox.Show("Task has been added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.RefreshDgv();

                this.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occured. Please try again. If the problem continues, contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );                
            }
        }

        
        private void Clear()
        {
            this.txtTask.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtTask.Text = string.Empty;
            this.cmbPriority.DataSource = Enum.GetValues(typeof(TaskPriority)); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
            this.Close();
        }
    }
}
