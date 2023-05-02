using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwTblOrgHierarchyUploadExcel
    {
        public string? EmployeeNumber { get; set; }
        public string? EmpName { get; set; }
        public string? CurrentDesignation { get; set; }
        public string? ReportingManager { get; set; }
        public string? ReportingManagerName { get; set; }
        public string? ReviewManager { get; set; }
        public string? ReviewManagerName { get; set; }
        public string? MobileNumber { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
