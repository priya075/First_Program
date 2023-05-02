using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class FacilityDataUpload
    {
        public double? Id { get; set; }
        public string? CustomerCif { get; set; }
        public string? BorrowerName { get; set; }
        public string? GroupCif { get; set; }
        public string? GroupName { get; set; }
        public string? LimitReferenceCode { get; set; }
        public string? LimitCode { get; set; }
        public string? LimitType { get; set; }
        public string? Cif { get; set; }
        public double? MyCode { get; set; }
        public string? Seq { get; set; }
        public string? ParentCode { get; set; }
        public string? IndependentOrGroup { get; set; }
        public string? IsGroupHeader { get; set; }
        public string? GroupMembership { get; set; }
        public string? ToInclude { get; set; }
        public string? GroupCode { get; set; }
        public string? ParentLimitReferenceCode { get; set; }
        public string? FacId { get; set; }
        public string? ParentFacId { get; set; }
        public string? ExistingLimit { get; set; }
        public string? Outstanding { get; set; }
        public string? LimitCurrency { get; set; }
        public string? MaximumTotal { get; set; }
        public string? Tenor { get; set; }
        public string? CountryofRisk { get; set; }
        public string? CountryPercentage { get; set; }
        public string? ApprovalDate { get; set; }
        public string? OfferedUntill { get; set; }
        public string? OnlinelimitDate { get; set; }
        public string? ProposalDate { get; set; }
        public string? ReviewFrequency { get; set; }
        public string? InterestRateKey { get; set; }
        public string? InterestType { get; set; }
        public string? Interestratecurrency { get; set; }
        public string? Spread { get; set; }
        public string? MinimumInterestRate { get; set; }
        public string? Notes { get; set; }
        public string? ExpiryDate { get; set; }
        public string? Branch { get; set; }
        public string? ArrangementFee { get; set; }
        public string? ReducingLimit { get; set; }
        public string? AvailableMarker { get; set; }
    }
}
