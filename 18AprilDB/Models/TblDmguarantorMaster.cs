using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmguarantorMaster
    {
        public int DmGrntId { get; set; }
        public int? DmId { get; set; }
        public int? DmDtypid { get; set; }
        public string? Guarantor { get; set; }
        public string? GuarantorType { get; set; }
        public string? GuarantorRating { get; set; }
        public DateTime? ValidityDate { get; set; }
        public bool? Revocability { get; set; }
        public bool? IsLimited { get; set; }
        public string? Relationship { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
