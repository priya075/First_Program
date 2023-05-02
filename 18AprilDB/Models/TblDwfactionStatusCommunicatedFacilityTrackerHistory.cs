using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDwfactionStatusCommunicatedFacilityTrackerHistory
    {
        public int DFHId { get; set; }
        public int? DFId { get; set; }
        public int? WfstdocId { get; set; }
        public int? Amid { get; set; }
        public string? Appid { get; set; }
        public string? FacId { get; set; }
        public string? ParentFacId { get; set; }
        public int? WfaId { get; set; }
        public int? RId { get; set; }
        public int? ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? XmlCommunicatedFacility { get; set; }
        public int? FactypId { get; set; }
        public string? FacType { get; set; }
        public string? LimitAmt { get; set; }
        public string? ExistLimit { get; set; }
        public string? Ccy { get; set; }
        public string? Utilization { get; set; }
        public string? Pricing { get; set; }
        public string? Charges { get; set; }
        public string? Tenor { get; set; }
        public string? Collaterals { get; set; }
        public string? Status { get; set; }
        public int? MWfId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? MId { get; set; }
    }
}
