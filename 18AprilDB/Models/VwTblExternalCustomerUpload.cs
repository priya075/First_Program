using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwTblExternalCustomerUpload
    {
        public string? CorpKey { get; set; }
        public string? Mobile { get; set; }
        public string? CustName { get; set; }
        public string? Pan { get; set; }
        public string? Manager { get; set; }
        public string? Segment { get; set; }
        public string? Subsegment { get; set; }
        public string? Industry { get; set; }
        public string? WholesaleFlg { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? CustomerType { get; set; }
        public string? OrganizationCode { get; set; }
        public string? OrganizationDescription { get; set; }
        public string? LegalConstitutionType { get; set; }
        public string? LegalConstitutionTypeDescription { get; set; }
        public string? CountryOfIncorporation { get; set; }
        public string? DateOfIncorporation { get; set; }
        public string? DateOfBirth { get; set; }
        public string? CustomerSince { get; set; }
        public string? RegOffcAddress { get; set; }
        public string? RegOffcAddressCity { get; set; }
        public string? RegOffcAddressState { get; set; }
        public string? RegOffcAddressCountry { get; set; }
        public string? MailingAddress { get; set; }
        public string? MailingAddressCity { get; set; }
        public string? MailingAddressState { get; set; }
        public string? MailingAddressCountry { get; set; }
        public string? InternalRating { get; set; }
        public string? InternalRatingDescription { get; set; }
        public string? Subsector { get; set; }
        public string? SubsectorDescription { get; set; }
        public string? SectorCode { get; set; }
        public string? SectorDescription { get; set; }
        public string? AverageAnnualIncome { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
