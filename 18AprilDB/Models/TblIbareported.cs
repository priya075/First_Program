using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblIbareported
    {
        public string? SNo { get; set; }
        public string? CircularDate { get; set; }
        public string? CircularNo { get; set; }
        public string? Name { get; set; }
        public string? DateOfOccurrence { get; set; }
        public string? DateOfDetection { get; set; }
        public string? PlaceOfOccurance { get; set; }
        public string? State { get; set; }
        public string? AmountInvolvedInLacs { get; set; }
        public string? NatureOfFraud { get; set; }
        public string? AreaOfOperation { get; set; }
        public string? ReportedBankName { get; set; }
        public string? VendorType { get; set; }
        public string? RelationshipToIncident { get; set; }
        public string? RelationshipToBank { get; set; }
        public string? BriefHistoryAndModusOperandi { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
