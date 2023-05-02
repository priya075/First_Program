using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcollateralGuarantee
    {
        public int CgrnId { get; set; }
        public int AcId { get; set; }
        public string Colid { get; set; } = null!;
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public string? Guarantor { get; set; }
        public string? GuarantorType { get; set; }
        public decimal? GuaranteeAmount { get; set; }
        public int? GuaranteeCurrency { get; set; }
        public bool? IsLimitedFlag { get; set; }
        public bool? IsRevocableFlag { get; set; }
        public DateTime? GuaranteeValidityDate { get; set; }
        public string? GuarantorCounterpartyRelationship { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
