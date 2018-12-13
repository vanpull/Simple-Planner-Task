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
    public partial class EmplyoeeTaskUpdateForm : Form
    {
        private CrudService<Task> _taskService;
        public static Employee LoggedInUser { get; set; }

        public delegate void DoEvent();
        public event DoEvent RefreshDgv;

        public Task SelectedTask { get; set; }

        public EmplyoeeTaskUpdateForm()
        {
            InitializeComponent();

            _taskService = new CrudService<Task>();           
        }

        private void EmplyoeeTaskUpdateForm_Load(object sender, EventArgs e)
        {
            this.lblTaskValue.Text = SelectedTask.Name;
            this.lblDescriptionValue.Text = SelectedTask.Description;
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if(SelectedTask != null)
            {

                int taskStatus = 0;
                foreach (Control control in this.grpStatus.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radio = control as RadioButton;
                        if (radio.Checked)
                        {
                            taskStatus = Convert.ToInt16(radio.Tag);
                        }
                    }
                }
                int actualTime = 0;

                if (taskStatus == (int)TaskStatus.Closed)
                {
                    if(txtActualTime.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter actual time", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        actualTime = Convert.ToInt32(txtActualTime.Text);
                        if(actualTime == 0)
                        {
                            MessageBox.Show("Please enter actual time", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                var task = _taskService.GetSingleById(SelectedTask.Id);                
                task.Status = taskStatus;
                if(taskStatus == (int)TaskStatus.Closed)
                {
                    task.ActualTime = actualTime;
                }
                
                _taskService.Update(task);

                MessageBox.Show("Task has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshDgv();
                this.Close();
            }

            
        }
    }
}
