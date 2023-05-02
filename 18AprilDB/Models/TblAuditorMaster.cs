using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAuditorMaster
    {
        public int AdId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool? IsBankApproved { get; set; }
        public string? AuditorGrade { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Address { get; set; }
    }
}
