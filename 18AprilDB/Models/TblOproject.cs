using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOproject
    {
        public int PrjId { get; set; }
        public string Projid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool? IsNonProject { get; set; }
        public bool? IsInActive { get; set; }
        public string? Description { get; set; }
        public string? PrimaryParty { get; set; }
        public string? LocationAddress { get; set; }
        public string? City { get; set; }
        public decimal? Cost { get; set; }
        /// <summary>
        /// FK to tblCurrency
        /// </summary>
        public int? Currency { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpectedCompletionDate { get; set; }
        public int? CtptId { get; set; }
        public int? SequenceNumber { get; set; }
        public int? PercentageComplete { get; set; }
        public string? ProjectDetails { get; set; }
        public string? ProjectConsultant { get; set; }
        public string? PaymentTerms { get; set; }
        public bool? AnyCostOverruns { get; set; }
        public bool? OnSchedule { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Comments { get; set; }
        public bool? IsAgriBased { get; set; }
        public DateTime? CommencementDate { get; set; }
        public string? ProjectOwnership { get; set; }
        public string? OtherCostDetailXml { get; set; }
        public decimal? InternalRateOfReturnOfProject { get; set; }
        public int? FinancialClosureAchieved { get; set; }
        public DateTime? ProjectCompletionDate { get; set; }
        public int? Arrangement { get; set; }
        public decimal? PaidUpCapital { get; set; }
        public string? GovernmentShare { get; set; }
    }
}
