using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class OsfacilityDetail
    {
        public int Id { get; set; }
        public string? CurrencyDescProposedLimit { get; set; }
        public string? Tenor { get; set; }
        public string? TenorUnit { get; set; }
        public int? Margin { get; set; }
        public int? MinimumRate { get; set; }
        public string? FacId { get; set; }
        public string? BillTenor { get; set; }
        public string? FacType { get; set; }
        public int? FactypId { get; set; }
        public string? ParentFacilityId { get; set; }
        public string? ParentFacilityIddesc { get; set; }
        public string? OriginalApplicationId { get; set; }
        public string? InAppStatus { get; set; }
        public int? Classification { get; set; }
        public string? ClassificationDesc { get; set; }
        public int? Type { get; set; }
        public string? TypeDesc { get; set; }
        public int? Subtype { get; set; }
        public string? SubtypeDesc { get; set; }
        public double? AmountProposedLimit { get; set; }
        public string? CurrencyProposedLimit { get; set; }
        public double? AmountExistingLimit { get; set; }
        public string? CurrencyExistingLimit { get; set; }
        public string? CurrencyDescExistingLimit { get; set; }
        public double? AmountUtilization { get; set; }
        public string? CurrencyUtilization { get; set; }
        public string? CurrencyDescUtilization { get; set; }
        public double? ExistLimit { get; set; }
        public int? ParentFacId { get; set; }
        public double? ProcessingFee { get; set; }
        public int? DeptId { get; set; }
        public int? SanctionId { get; set; }
        public string? OnSancationState { get; set; }
    }
}
