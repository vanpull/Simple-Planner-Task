using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Domain
{
    public class Employee : IEntity 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", this.FirstName, this.LastName); } }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
