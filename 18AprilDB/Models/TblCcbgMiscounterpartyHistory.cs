using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCcbgMiscounterpartyHistory
    {
        public int WfstId { get; set; }
        public int CtptId { get; set; }
        public string? UniqueId { get; set; }
        public string? CounterPartyName { get; set; }
        public string? PanNo { get; set; }
        public string? FinacleCifId { get; set; }
        public string? LmsId { get; set; }
        public string? GroupName { get; set; }
        public string? CtptStateCode { get; set; }
        public string? CtptState { get; set; }
        public string? CtptCity { get; set; }
        public string? RegionalHead { get; set; }
        public string? Rm { get; set; }
        public string? SourcingChannel { get; set; }
        public int? RatingFrom { get; set; }
        public string? GrmId { get; set; }
        public int? BuId { get; set; }
        public string? ExternalRating { get; set; }
        public string? BusinessType { get; set; }
        public string? MsmeType { get; set; }
        public string? Industry { get; set; }
        public string? NatureOfBusiness { get; set; }
        public string? BsrActivity { get; set; }
    }
}
