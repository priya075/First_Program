using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFacilityDailyUploadDatum
    {
        public string LimitReferenceCode { get; set; } = null!;
        public string? CustomerCif { get; set; }
        public string? FacilityId { get; set; }
        public string? ExistingCbslimitAmount { get; set; }
        public string? ExistingCbslimitCurrencyDesc { get; set; }
        public string? UtilizationAmount { get; set; }
        public string? UtilizationCurrencyDesc { get; set; }
        public string? TransactionId { get; set; }
        public DateTime? ExposureStartDate { get; set; }
        public DateTime? ExposureEndDate { get; set; }
        public string? ProductType { get; set; }
    }
}
