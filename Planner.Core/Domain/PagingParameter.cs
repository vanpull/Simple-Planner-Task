using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Core.Domain
{

    /// <summary>
    /// Parameters for Paginated Queries
    /// </summary>
    public class PagingParameter
    {
        public int PageIndex { get; set; } //PageIndex
        public int PageSize { get; set; } //PageSize
        public string GlobalSearchText { get; set; }
        public int? ActiveFilter { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
        public bool? IsExport { get; set; }
    }
}
