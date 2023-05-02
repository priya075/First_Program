using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwEligTblCounterparty
    {
        public decimal? Age { get; set; }
        public int CtptId { get; set; }
        public string CounterPartyName { get; set; } = null!;
        public string? UniqueId { get; set; }
        public Guid? CtptGuid { get; set; }
        public string? FaxNumber { get; set; }
        public string? BusinessUnit { get; set; }
        public bool? LegalTypeFlag { get; set; }
        public int? LtId { get; set; }
        public int? CptId { get; set; }
        public int? DomicileCountry { get; set; }
        public int? Industry { get; set; }
        public DateTime? IncoporationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? BrId { get; set; }
        public bool? ConfidentialIndicator { get; set; }
        public int? AsId { get; set; }
        public int? DcId { get; set; }
        public string? ControlState { get; set; }
        public bool? InProcess { get; set; }
        public string? UserDefinedFields { get; set; }
        public string? WebsiteAddress { get; set; }
        public DateTime? CustomerSince { get; set; }
        public int? CbeconomicSectorCode { get; set; }
        public int? BaselEntityType { get; set; }
        public string? Mrascore { get; set; }
        public string? MraratingGrade { get; set; }
        public bool? IsProsprective { get; set; }
        public int? CbrbclassificationId { get; set; }
        public bool? IsBoardMember { get; set; }
        public string? ExistingRiskRate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsAppCreated { get; set; }
        public decimal? SalesTurnOver { get; set; }
        public int? IncCountryId { get; set; }
        public int? BuId { get; set; }
        public string? PrimaryAliasId { get; set; }
        public int? SecBestRating { get; set; }
        public string? LegalName { get; set; }
        public string? ListingStatus { get; set; }
        public string? EfilingStatus { get; set; }
        public decimal? AuthCapital { get; set; }
        public decimal? PaidupCapital { get; set; }
        public string? CustomerCategory { get; set; }
        public DateTime? DateOfCompanyFetch { get; set; }
        public DateTime? DateOfDirectorsFetch { get; set; }
        public DateTime? DateOfChargesFetch { get; set; }
        public decimal? Promoters { get; set; }
        public decimal? ForeignBodiesCorporate { get; set; }
        public decimal? Banks { get; set; }
        public int? IsExposureForeign { get; set; }
        public string? BookingUnit { get; set; }
        public string? CustomerSize { get; set; }
        public string? EnterpriseSector { get; set; }
        public string? InvestmentEquipment { get; set; }
        public bool? UwsdeviationsSecurityNetWorth { get; set; }
        public bool? ExemptQcr { get; set; }
        public decimal? MarketCap { get; set; }
        public int? RatingFrom { get; set; }
        public int? MonitoringStatus { get; set; }
        public int? Actionable { get; set; }
        public string? ReasonForStress { get; set; }
        public DateTime? IncorpInAstar { get; set; }
        public int? Astarclassification { get; set; }
        public int? Iracstatus { get; set; }
        public int? CustomerStyle { get; set; }
        public string? McaOldName { get; set; }
        public string? McaPan { get; set; }
        public string? McaEmailId { get; set; }
        public string? McaCompanyCategory { get; set; }
        public string? McaCompanySubCategory { get; set; }
        public string? McaIndustry { get; set; }
        public string? McaSector { get; set; }
        public DateTime? McaDateOfBalanceSheet { get; set; }
        public string? McaRoCCode { get; set; }
        public string? McaNumberOfMembers { get; set; }
        public string? McaClassification { get; set; }
        public DateTime? McaLastAgmDate { get; set; }
        public string? CtptXml { get; set; }
        public string Profession { get; set; } = null!;
        public int AnnualizedTurnover { get; set; }
        public int BusinessVintage { get; set; }
        public string LocationCityLimits { get; set; } = null!;
        public int LocationVintage { get; set; }
        public string LocationMetroCity { get; set; } = null!;
        public string LocationNegativeList { get; set; } = null!;
        public string ResiOffOwnedBorrower { get; set; } = null!;
        public string ResiOffOwnedParentsBorrower { get; set; } = null!;
        public string ResiOffOwnedBrotherOwningBrotherCoApplicant { get; set; } = null!;
        public int ExperiencePromoter { get; set; }
        public int MonthlyObligation { get; set; }
        public int Revenue { get; set; }
        public int OperatingCosts { get; set; }
        public int SalaryPromoter { get; set; }
        public int Ebidta { get; set; }
        public int FinChargesBorrowers { get; set; }
        public int DepreciationAmortization { get; set; }
        public int Pbt { get; set; }
        public int Tax { get; set; }
        public int Pat { get; set; }
        public int Abb { get; set; }
    }
}
