using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Domain
{
    /// <summary>
    /// BaseEntity
    /// </summary>
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
