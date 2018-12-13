using System;

namespace Planner.Core.Domain
{
    /// <summary>
    /// Represents Task Table
    /// </summary>
    public class Task : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Priority { get; set; }
        public Priority TaskPriority { get; set; }
        public int? Status { get; set; }
        public Status TaskStatus { get; set; }
        public int? AssignedTo { get; set; }
        public Employee Employee { get; set; }
        public int? AssignedBy { get; set; }
        public Employee Manager { get; set; }
        public DateTime CreatedOn { get; set; }
        public int EstimatedTime { get; set; }
        public int? ActualTime { get; set; }

        public string EmployeeName
        {
            get
            {
                if(this.Employee != null)
                {
                    return this.Employee.FullName;
                }
                return null;
            }
        }

        public string ManagerName
        {
            get
            {
                if (this.Manager != null)
                {
                    return this.Manager.FullName;
                }
                return null;
            }
        }

        public string TaskStatusName
        {
            get
            {
                if (this.TaskStatus != null)
                {
                    return this.TaskStatus.Name;
                }
                return null;
            }
        }

        
    }
}
