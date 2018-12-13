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
    public partial class EmployeeForm : Form
    {
        private CrudService<Task> _taskService;

        public static Employee LoggedInUser { get; set; }
        public EmployeeForm()
        {
            InitializeComponent();

            _taskService = new CrudService<Task>();

            ConfigureDataGridView();

            LoadTasks();
        }

        private void ConfigureDataGridView()
        {
            dgvTaskList.AutoGenerateColumns = false;

            //dgvTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvTaskList.AutoResizeColumns();
            //dgvTaskList.AllowUserToResizeColumns = true;
            //dgvTaskList.AllowUserToOrderColumns = true;

            dgvTaskList.ColumnCount = 5;

            dgvTaskList.Columns[0].Name = "Name";
            dgvTaskList.Columns[0].HeaderText = "Task";
            dgvTaskList.Columns[0].DataPropertyName = "Name";
            dgvTaskList.Columns[0].Width = 148;

            dgvTaskList.Columns[1].Name = "CreatedOn";
            dgvTaskList.Columns[1].HeaderText = "Created On";
            dgvTaskList.Columns[1].DataPropertyName = "CreatedOn";
            dgvTaskList.Columns[1].Width = 148;

            dgvTaskList.Columns[2].Name = "EstimatedTime";
            dgvTaskList.Columns[2].HeaderText = "Estimated Effort";
            dgvTaskList.Columns[2].DataPropertyName = "EstimatedTime";
            dgvTaskList.Columns[2].Width = 148;

            dgvTaskList.Columns[3].Name = "TaskStatusName";
            dgvTaskList.Columns[3].HeaderText = "Task Status";
            dgvTaskList.Columns[3].DataPropertyName = "TaskStatusName";
            dgvTaskList.Columns[3].Width = 148;

            dgvTaskList.Columns[4].Name = "AssignedBy";
            dgvTaskList.Columns[4].HeaderText = "Assigned By";
            dgvTaskList.Columns[4].DataPropertyName = "ManagerName";
            dgvTaskList.Columns[4].Width = 148;

        }

        private void LoadTasks()
        {
            try
            {
                var tasks = _taskService.GetList(a=>a.AssignedTo == LoggedInUser.Id, a => a.Employee, a => a.Manager, a=>a.TaskStatus);
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

        private void dgvTaskList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                try
                {
                    Task selectedTask = (Task)dgvTaskList.CurrentRow.DataBoundItem;
                    EmplyoeeTaskUpdateForm updateForm = new EmplyoeeTaskUpdateForm();
                    updateForm.SelectedTask = selectedTask;
                    updateForm.RefreshDgv += new EmplyoeeTaskUpdateForm.DoEvent(EmplyoeeTaskUpdateForm_RefreshDgv);
                    updateForm.Show();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
            }
        }
        private void EmplyoeeTaskUpdateForm_RefreshDgv()
        {
            LoadTasks();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
