using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCurrency
    {
        public int CrId { get; set; }
        public string? AlphaCode { get; set; }
        public string? NumCode { get; set; }
        public string? Currency { get; set; }
        public decimal? Rate { get; set; }
        public int? CountryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? Decimals { get; set; }
        public string? CurrencyName { get; set; }
        public int? MstSourceId { get; set; }
        public DateTime? RateDate { get; set; }
        public bool? AllowedLimitsCurrency { get; set; }
    }
}
