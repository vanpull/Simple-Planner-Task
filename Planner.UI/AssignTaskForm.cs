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
    public partial class AssignTaskForm : Form
    {

        private CrudService<Task> _taskService;
        private CrudService<Employee> _employeeService;
        public static Employee LoggedInUser { get; set; }

        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        public AssignTaskForm()
        {
            InitializeComponent();

            _taskService = new CrudService<Task>();
            _employeeService = new CrudService<Employee>();

            this.dtpStartDate.Value = DateTime.Now;

            LoadDropDown();

        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEstimatedEffort.Text))
                {
                    errorProvider.SetError(txtEstimatedEffort, "Please enter estimated effort");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtEstimatedEffort, "");
                }

                DateTime selectedDate = dtpStartDate.Value;

                if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Task can't be assigned on Saturday and Sunday", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                int taskId = Convert.ToInt32(cmbTask.SelectedValue);
                int employeeId = Convert.ToInt32(cmdEmployee.SelectedValue);


                var taskAssigned = _taskService.GetList(x => x.AssignedTo == employeeId
                                    && x.Status != (int)TaskStatus.Closed).Any();

                if (taskAssigned)
                {
                    MessageBox.Show("Selected employee has already assigned with a task, Kindly choose a different emplyoee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var task = _taskService.GetSingleById(taskId);
                    task.AssignedBy = LoggedInUser.Id;
                    task.AssignedTo = employeeId;
                    task.Status = (int)TaskStatus.Assigned;
                    task.EstimatedTime = Convert.ToInt32(txtEstimatedEffort.Text);

                    _taskService.Update(task);

                    MessageBox.Show("Task has been assigned successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Clear();

                    this.RefreshDgv();
                    this.Close();
                }


                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDropDown()
        {
            var tasks = _taskService.GetList(x => !x.AssignedTo.HasValue);
            var employees = _employeeService.GetList(x => x.RoleId == 2);

            cmbTask.DataSource = tasks;
            cmbTask.DisplayMember = "Name";
            cmbTask.ValueMember = "Id";
            cmdEmployee.DataSource = employees;
            cmdEmployee.DisplayMember = "FullName";
            cmdEmployee.ValueMember = "Id";

        }

        private void Clear()
        {
            this.txtEstimatedEffort.Text = string.Empty;
            LoadDropDown();
        }

        private void txtEstimatedEffort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEstimatedEffort_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEffortEstimate_Click(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            //var picker = (DateTimePicker)sender;
            //ValidateDate(picker);

        }

        private void ValidateDate(DateTimePicker picker)
        {
            DateTime selectedDate = picker.Value;
            if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Task can't be assigned on Saturday and Sunday", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
