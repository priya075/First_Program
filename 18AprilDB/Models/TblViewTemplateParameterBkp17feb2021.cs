using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblViewTemplateParameterBkp17feb2021
    {
        public int VprmId { get; set; }
        public int PrmId { get; set; }
        public int? TmpId { get; set; }
        public int? TmpSubId { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? DisplaySeq { get; set; }
        public string? PrmType { get; set; }
        public string? ViewParamterName { get; set; }
        public decimal? Multiplier { get; set; }
        public string? Suffix { get; set; }
    }
}
