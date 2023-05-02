using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDminsuranceCertificate
    {
        public int DmInscertId { get; set; }
        public int? DmId { get; set; }
        public int? DmDtypid { get; set; }
        public DateTime? InsuranceDate { get; set; }
        public string? InsuranceType { get; set; }
        public string? InsurancePolicyNumber { get; set; }
        public decimal? SumInsured { get; set; }
        public string? Insurer { get; set; }
        public string? Beneficiary { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? PremiumPaymentStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
