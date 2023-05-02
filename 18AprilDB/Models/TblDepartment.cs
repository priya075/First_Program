using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDepartment
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? DepartmentCode { get; set; }
        public decimal? OperationalCostIncome { get; set; }
        public bool? IsActive { get; set; }
        public string? DeptType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
