using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblProgramAssesmentParamMaster
    {
        public int Paid { get; set; }
        public string? AssesmentName { get; set; }
        public int? PatypId { get; set; }
        public int? FactypId { get; set; }
        public string? AssesmentXml { get; set; }
        public int? Version { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
