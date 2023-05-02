using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTemplateParameter
    {
        public int PrmId { get; set; }
        public int? TmpId { get; set; }
        public string? ParamterName { get; set; }
        public string? ParameterDataTableColumn { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? TmpSubId { get; set; }
        public string? ValueType { get; set; }
        public bool? IsAbsolute { get; set; }
    }
}
