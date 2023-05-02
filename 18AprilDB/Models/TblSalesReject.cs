using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblSalesReject
    {
        public string? Id { get; set; }
        public string? NameOfApplicant { get; set; }
        public string? Zone { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? PanCinNo { get; set; }
        public string? AmountOfTheFacilityProposedInLakh { get; set; }
        public string? NatureOfBusiness { get; set; }
        public string? DateOfRejection { get; set; }
        public string? ReasonsForReject { get; set; }
        public string? KeyPromoterDirectorName { get; set; }
        public string? NameOfTheRm { get; set; }
        public string? NameOfRhRsm { get; set; }
        public string? BusinessSegment { get; set; }
        public string? ItemType { get; set; }
        public string? Path { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
