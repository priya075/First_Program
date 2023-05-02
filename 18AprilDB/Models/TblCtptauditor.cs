using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptauditor
    {
        public int CadId { get; set; }
        public string? CtptId { get; set; }
        public string? Name { get; set; }
        public string? AdId { get; set; }
        public bool? IsBankApproved { get; set; }
        public string? AuditorGrade { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? SigningPartner { get; set; }
    }
}
