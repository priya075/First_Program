using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllWithFacilityTypeTblCcfmatrix
    {
        public int Ccfmid { get; set; }
        public int Factypid { get; set; }
        public int? T24pid { get; set; }
        public bool? IsRevolving { get; set; }
        public decimal CcfperYear { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string FacilityType { get; set; } = null!;
    }
}
