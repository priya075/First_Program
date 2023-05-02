using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwMistrackerDetail
    {
        public string? CredProId { get; set; }
        public string ApplicationId { get; set; } = null!;
        public string RestartedApplication { get; set; } = null!;
        public string? NameOfTheBorrower { get; set; }
        public string? PanNo { get; set; }
        public string? CifId { get; set; }
        public string? Constitution { get; set; }
        public string? GroupName { get; set; }
        public string? Zone { get; set; }
        public string? State { get; set; }
        public string? CreditCenter { get; set; }
        public string? Branch { get; set; }
        public string? LmsId { get; set; }
        public string? CreditAnalyst { get; set; }
        public string? CreditLoginBy { get; set; }
        public string UnitHead { get; set; } = null!;
        public string ZonalHead { get; set; } = null!;
        public string? RegionalHead { get; set; }
        public string? Rm { get; set; }
        public string? CurrentUserName { get; set; }
        public string? CurrentUserRole { get; set; }
        public string? CurrentRolePendingSince { get; set; }
        public string? SourcingChannel { get; set; }
        public string? SourcingChannelType { get; set; }
        public string? SourcingChannelTypeDesc { get; set; }
        public string ModeOfFacility { get; set; } = null!;
        public string? BtBankName { get; set; }
        public string? Product { get; set; }
        public string? TypeOfApplication { get; set; }
        public decimal? FundBased { get; set; }
        public decimal? NonFundBased { get; set; }
        public decimal? Loans { get; set; }
        public decimal? DerivativesAsPerPfeAmount { get; set; }
        public decimal? DerivativesAsPerNotionAmount { get; set; }
        public decimal? TotalFacility { get; set; }
        public decimal? IncrementalExposureInLakhs { get; set; }
        public string? ApplicationStartDate { get; set; }
        public string? DateOfLogin { get; set; }
        public string? LoginMonth { get; set; }
        public string? LoginAcceptanceDate { get; set; }
        public string? ApplicationClosedDate { get; set; }
        public int? LoginToAcceptanceTat { get; set; }
        public int? BusinessTat { get; set; }
        public int? CreditTat { get; set; }
        public int? CommitteeTat { get; set; }
        public int? TotalTat { get; set; }
        public string? ProposedBankingArrangement { get; set; }
        public string? StatusOfApplication { get; set; }
        public string ReasonsOfDeclineWithdrawnRejection { get; set; } = null!;
        public string ReasonsOfDeclineWithdrawnAdditionalRemarks { get; set; } = null!;
        public string ApprovingAuthority { get; set; } = null!;
        public string? ManualOverrideYN { get; set; }
        public string? ManualOverrideDop { get; set; }
        public string? ManualOverrideComments { get; set; }
        public string CreditApproverName { get; set; } = null!;
        public string SecretoryVote { get; set; } = null!;
        public string CreditSecName { get; set; } = null!;
        public string? InternalScoreRating { get; set; }
        public string? ExternalRating { get; set; }
        public string? BusinessType { get; set; }
        public string? MsmeType { get; set; }
        public string? TertiaryIndustryName { get; set; }
        public string? NatureOfBusiness { get; set; }
        public string? SecondaryIndustryName { get; set; }
        public int? LatestAuditedFinancial { get; set; }
        public decimal? LatestAuditedTurnover { get; set; }
        public string? ExposureDeviations { get; set; }
        public string? BorrowerProfileDeviations { get; set; }
        public string? FinancialParametersDeviations { get; set; }
        public string? BankingHistoryDeviations { get; set; }
        public string? DefaultHistoryDeviations { get; set; }
        public string? OwnerMarginDeviations { get; set; }
        public string? RiskParameterScoreDeviations { get; set; }
        public string? PromoterAndGuarantorAgeDeviations { get; set; }
        public string? AssessmentDeviations { get; set; }
        public string? CollateralDeviations { get; set; }
        public string? PersonalGuaranteeDeviations { get; set; }
        public string? TenorDeviations { get; set; }
        public string? OtherDeviations { get; set; }
        public string ApprovalMonth { get; set; } = null!;
        public string CrossCollateral { get; set; } = null!;
        public string? SegmentCrossCollateral { get; set; }
        public int? DisbusrementDate { get; set; }
        public decimal? ActualCollateralCover { get; set; }
        public decimal? ActualCoverPercent { get; set; }
        public string? RmUid { get; set; }
        public int? CreditAnalystUid { get; set; }
        public int CountPostCfd { get; set; }
        public int? TotalCount { get; set; }
        public string? Wfname { get; set; }
        public int? MWfId { get; set; }
        public DateTime ReportDate { get; set; }
        public string? SanctionDate { get; set; }
        public string LegalEntityIdentifier { get; set; } = null!;
        public string? LegalEntityIdentifierExpiryDate { get; set; }
        public string? Urcavailable { get; set; }
        public string? Urcnumber { get; set; }
        public string? UdyamRegistrationCertificationDate { get; set; }
        public string? FinacleMsmeclassification { get; set; }
        public string? SubSegment { get; set; }
        public string? Cibilrank { get; set; }
        public DateTime? Cibildate { get; set; }
    }
}
