using Planner.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Service
{
    /// <summary>
    /// Employee Service class for Login 
    /// </summary>
    public class EmployeeService : CrudService<Employee>
    {
        public EmployeeService()
        {

        }

        public virtual Employee Authenticate(string email, string password)
        {
            var emp = GetSingle(a => a.Email.ToLower().Equals(email.ToLower()) && a.Password.Equals(password));
            return emp;
        }
    }
}
