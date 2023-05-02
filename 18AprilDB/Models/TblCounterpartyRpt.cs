using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCounterpartyRpt
    {
        public int CtptId { get; set; }
        public string CounterPartyName { get; set; } = null!;
        public string? UniqueId { get; set; }
        public string? WfGuid { get; set; }
        public Guid? CtptGuid { get; set; }
        public int? ParentCtptuniqueId { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? FaxNumber { get; set; }
        public string? EmailId { get; set; }
        public string? ContactPerson { get; set; }
        public bool? DirectContact { get; set; }
        public int? GroupRmid { get; set; }
        public string? OtherRm { get; set; }
        public string? BusinessUnit { get; set; }
        public bool? LegalTypeFlag { get; set; }
        public int? LtId { get; set; }
        public int? CptId { get; set; }
        public int? DomicileCountry { get; set; }
        public int? Industry { get; set; }
        public string? Rating { get; set; }
        public string? RatingDate { get; set; }
        public DateTime? IncoporationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Swiftcode { get; set; }
        public int? BrId { get; set; }
        public bool? ConfidentialIndicator { get; set; }
        public int? AsId { get; set; }
        public int? DcId { get; set; }
        public bool? IsListed { get; set; }
        public int? LiId { get; set; }
        public bool? IsBankApprovedAuditor { get; set; }
        public int? AdId { get; set; }
        public string? BloombergId { get; set; }
        public string? ReutersId { get; set; }
        public string? DunNumber { get; set; }
        public string? CounterpartyAlias { get; set; }
        public string? PrimaryRiskAnalyst { get; set; }
        public string? PassportNo { get; set; }
        public bool? InProcess { get; set; }
        public string? UserDefinedFields { get; set; }
        public string? WfStatus { get; set; }
        public string? DirectEmailId { get; set; }
        public string? WebsiteAddress { get; set; }
        public int? CustomerCif { get; set; }
        public int? GroupCif { get; set; }
        public DateTime? CustomerSince { get; set; }
        public int? CbeconomicSectorCode { get; set; }
        public int? BaselEntityType { get; set; }
        public string? Mrascore { get; set; }
        public string? MraratingGrade { get; set; }
        public string? GroupName { get; set; }
        public int? Daoid { get; set; }
        public string? Daocode { get; set; }
        public string? DaobussinessLine { get; set; }
        public bool? IsProsprective { get; set; }
        public int? GroupDaoid { get; set; }
        public string? GroupDaocode { get; set; }
        public string? GroupDaobussinessLine { get; set; }
        public int? CbrbclassificationId { get; set; }
        public bool? IsBoardMember { get; set; }
        public string? TradeLicenseNo { get; set; }
        public string? TradelicenseExpirydate { get; set; }
        public string? ExistingRiskRate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? CtptidentificationId { get; set; }
        public bool IsAppCreated { get; set; }
        public decimal? SalesTurnOver { get; set; }
        public int? CustomerRelation { get; set; }
    }
}
