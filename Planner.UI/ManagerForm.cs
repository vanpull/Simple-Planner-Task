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
    public partial class ManagerForm : Form
    {

        private CrudService<Task> _taskService;

        public static Employee LoggedInUser { get; set; }

        public ManagerForm()
        {
            InitializeComponent();

            _taskService = new CrudService<Task>();

            ConfigureDataGridView();

            LoadTasks();

            
        }

        private void menuNewTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.RefreshDgv += new TaskForm.DoEvent(TaskForm_RefreshDgv);        
            taskForm.Show();
            taskForm.Owner = this;
        }

        private void TaskForm_RefreshDgv()
        {
            LoadTasks();
        }

        private void menuAssignTask_Click(object sender, EventArgs e)
        {
            AssignTaskForm assignForm = new AssignTaskForm();
            assignForm.RefreshDgv += new AssignTaskForm.DoEvent(TaskForm_RefreshDgv);
            assignForm.Show();
            assignForm.Owner = this;
        }

        private void ConfigureDataGridView()
        {
            dgvTaskList.AutoGenerateColumns = false;

            //dgvTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvTaskList.AutoResizeColumns();
            //dgvTaskList.AllowUserToResizeColumns = true;
            //dgvTaskList.AllowUserToOrderColumns = true;

            dgvTaskList.ColumnCount = 6;

            dgvTaskList.Columns[0].Name = "Name";
            dgvTaskList.Columns[0].HeaderText = "Task";
            dgvTaskList.Columns[0].DataPropertyName = "Name";
            dgvTaskList.Columns[0].Width = 124;

            dgvTaskList.Columns[1].Name = "CreatedOn";
            dgvTaskList.Columns[1].HeaderText = "Created On";
            dgvTaskList.Columns[1].DataPropertyName = "CreatedOn";
            dgvTaskList.Columns[1].Width = 124;

            dgvTaskList.Columns[2].Name = "EstimatedTime";
            dgvTaskList.Columns[2].HeaderText = "Estimated Effort";
            dgvTaskList.Columns[2].DataPropertyName = "EstimatedTime";
            dgvTaskList.Columns[2].Width = 124;

            dgvTaskList.Columns[3].Name = "AssignedTo";
            dgvTaskList.Columns[3].HeaderText = "Assigned To";
            dgvTaskList.Columns[3].DataPropertyName = "EmployeeName";
            dgvTaskList.Columns[3].Width = 124;

            dgvTaskList.Columns[4].Name = "AssignedBy";
            dgvTaskList.Columns[4].HeaderText = "Assigned By";
            dgvTaskList.Columns[4].DataPropertyName = "ManagerName";
            dgvTaskList.Columns[4].Width = 124;

            dgvTaskList.Columns[5].Name = "TaskStatus";
            dgvTaskList.Columns[5].HeaderText = "Task Status";
            dgvTaskList.Columns[5].DataPropertyName = "TaskStatusName";
            dgvTaskList.Columns[5].Width = 124;

        }

        private void LoadTasks()
        {
            try
            {
                var tasks = _taskService.GetAll(a => a.Employee, a => a.Manager, a=>a.TaskStatus);
               // ConfigureDataGridView();
                dgvTaskList.DataSource = tasks;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvTaskList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //var dataGridView = sender as DataGridView;
            //if (dataGridView != null)
            //{
            //    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
