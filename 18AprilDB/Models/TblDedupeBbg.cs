using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDedupeBbg
    {
        public string? Segment { get; set; }
        public string? Region { get; set; }
        public string? Branch { get; set; }
        public string? NameOfTheCompany { get; set; }
        public string? CompanyPan { get; set; }
        public string? ApplicationDate { get; set; }
        public string? PromoterName { get; set; }
        public string? PromoterPan { get; set; }
        public string? AmountApplied { get; set; }
        public string? DecisionRejectWithdrawnSanctioned { get; set; }
        public string? Remarks { get; set; }
        public string? Id { get; set; }
        public string? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
