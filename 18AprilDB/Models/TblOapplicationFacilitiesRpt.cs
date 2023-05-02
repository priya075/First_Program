using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationFacilitiesRpt
    {
        public int Afid { get; set; }
        public int Amid { get; set; }
        public string? Facid { get; set; }
        public int? Type { get; set; }
        public string? TypeDesc { get; set; }
        public int? Subtype { get; set; }
        public string? SubtypeDesc { get; set; }
        public int? Fstprodid { get; set; }
        public string? FacProduct { get; set; }
        public string? InitialSnid { get; set; }
        public string? CurrentSnid { get; set; }
        public string? InApplicationFacilityStatus { get; set; }
        public string? OnSanctionState { get; set; }
        public int? EligibleFacilitySubTypes { get; set; }
        public string? ParentFacilityId { get; set; }
        public decimal ProposedLimit { get; set; }
        public int ProposedLimitCurrency { get; set; }
        public decimal? ExistingLimit { get; set; }
        public int? ExistingLimitCurrency { get; set; }
        public decimal? CurrentUtilization { get; set; }
        public int? UtilizationCurrency { get; set; }
        public int? Tenor { get; set; }
        public string? TenorUnit { get; set; }
        public int? Cbstenor { get; set; }
        public string? SpecificMitigants { get; set; }
        public bool IsCoverageBasedFlag { get; set; }
        public bool? PricingFixedOrFloatingFlag { get; set; }
        public int? PricingReferenceRates { get; set; }
        public decimal? PricingMarginOverReferenceRate { get; set; }
        public decimal? PricingMinimumrate { get; set; }
        public decimal? FcProcessingFees { get; set; }
        public decimal? FcArrangementFee { get; set; }
        public decimal? FcCommission { get; set; }
        public bool? RevolvingFlag { get; set; }
        public bool? OneOffFlag { get; set; }
        public int? ProjectId { get; set; }
        public string? CashMarginUnit { get; set; }
        public decimal? CashMarginAmount { get; set; }
        public string? Description { get; set; }
        public string? TermsAndCondition { get; set; }
        public string? Status { get; set; }
        public string? MoratoriumPeriodDays { get; set; }
        public string? RepaymentInstruction { get; set; }
        public DateTime? DateOfFirstRepayment { get; set; }
        public string? PrincipalServicingFreq { get; set; }
        public string? InterestServicingFreq { get; set; }
        public string? PrepaymentPenalty { get; set; }
        public bool? DrawdownInTranches { get; set; }
        public decimal? MinimumDrawdown { get; set; }
        public decimal? MaximumDrawdown { get; set; }
        public string? ConditionsOfDrawdown { get; set; }
        public string? DisbursementInstructions { get; set; }
        public string? PurposeEndUse { get; set; }
        public DateTime? FinalMaturityDate { get; set; }
        public string? AvailabilityPeriodDays { get; set; }
        public int? FacilityLevel { get; set; }
        public string? LimitReferenceCode { get; set; }
        public int? FactypFclsid { get; set; }
        public int? FstypFclsid { get; set; }
        public int? FstprodFclsid { get; set; }
        public int? UtilizationType { get; set; }
        public decimal? ApprovedLimit { get; set; }
        public int? ApprovedLimitCcy { get; set; }
        public string? Purpose { get; set; }
        public string? JointUtilization { get; set; }
        public string? Conditions { get; set; }
        public int? FvinterestRate { get; set; }
        public string? FinterestRate { get; set; }
        public string? VbaseRate { get; set; }
        public string? Vmargin { get; set; }
        public DateTime? FacilityExpirydDate { get; set; }
        public string? Commission { get; set; }
        public string? FdunderPledge { get; set; }
        public DateTime? Validity { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? MinInterestRate { get; set; }
        public string? InterestServicingAccount { get; set; }
        public string? DisbursementAccount { get; set; }
        public decimal? RepaymentAmount { get; set; }
        public int? PrincipalRepaymentFrequency { get; set; }
        public string? RepaymentAccount { get; set; }
        public string? SecuritySpecifically { get; set; }
        public int? OverdraftType { get; set; }
        public string? AccountNo { get; set; }
        public string? DrawnDownDetails { get; set; }
        public int? LeniarOrAnnuity { get; set; }
        public int? MWfId { get; set; }
        public DateTime? ExtensionRequestDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? GlobalType { get; set; }
        public string? GlobalTypeDesc { get; set; }
        public int? FacglobFclsid { get; set; }
    }
}
