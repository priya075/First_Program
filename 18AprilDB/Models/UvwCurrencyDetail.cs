using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwCurrencyDetail
    {
        public int CrId { get; set; }
        public string? AlphaCode { get; set; }
        public string? NumCode { get; set; }
        public string? Currency { get; set; }
        public int? CountryId { get; set; }
        public string? Country { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public decimal? Rate { get; set; }
    }
}
