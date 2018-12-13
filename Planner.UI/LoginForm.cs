using Planner.Core.Domain;
using Planner.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner.UI
{
    public partial class LoginForm : Form
    {
        private EmployeeService _employeeService;
        public LoginForm()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider.SetError(txtEmail, "Please enter email");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtEmail, "");
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider.SetError(txtPassword, "Please enter password");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtPassword, "");
                }

                Employee employee = _employeeService.Authenticate(txtEmail.Text, txtPassword.Text);

                if (employee != null)
                {
                    ManagerForm.LoggedInUser = employee;
                    EmployeeForm.LoggedInUser = employee;
                    TaskForm.LoggedInUser = employee;
                    AssignTaskForm.LoggedInUser = employee;

                    if (employee.RoleId == (int)EmplyoeeRole.Manager)
                    {
                        ManagerForm managerForm = new ManagerForm();                        
                        managerForm.Show();
                        this.Hide();
                    }

                    if (employee.RoleId == (int)EmplyoeeRole.Employee)
                    {
                        EmployeeForm emplyoeeForm = new EmployeeForm();
                        emplyoeeForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Clear();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Clear()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
