using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class AppsummaryCalculation
    {
        public string? FacilityId { get; set; }
        public int? AppBaseCurrencyId { get; set; }
        public string? AppBaseCurrency { get; set; }
        public int? AmountProposedLimit { get; set; }
        public int? CurrencyProposedLimitId { get; set; }
        public string? CurrencyProposedLimit { get; set; }
        public int? ClassificationId { get; set; }
        public string? Classification { get; set; }
        public int? ColTypeId { get; set; }
        public string? ColType { get; set; }
        public int? ColSubtypeId { get; set; }
        public string? ColSubColType { get; set; }
        public string? ParentFacilityId { get; set; }
        public string? OriginalApplicationId { get; set; }
        public string? Clsflag { get; set; }
        public decimal? BaseCr { get; set; }
    }
}
