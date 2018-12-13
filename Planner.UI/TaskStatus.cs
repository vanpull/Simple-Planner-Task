using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.UI
{
    public enum TaskStatus
    {
        Assigned = 1,
        InProgress = 2,
        Deferred = 3,
        Completed = 4,
        Closed = 5
    }

    public enum EmployeeTaskStatus
    {
        InProgress = 2,       
        Completed = 4,
        Closed = 5
    }
}
