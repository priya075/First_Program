using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusFacilityTrackerRpt
    {
        public int WfstfacId { get; set; }
        public int WfstappId { get; set; }
        public string FacId { get; set; } = null!;
        public string? ParentFacId { get; set; }
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public string XmlFacility { get; set; } = null!;
        public int? FactypId { get; set; }
        public string FacType { get; set; } = null!;
        public string LimitAmt { get; set; } = null!;
        public string? ExistLimit { get; set; }
        public string Ccy { get; set; } = null!;
        public string Utilization { get; set; } = null!;
        public string Pricing { get; set; } = null!;
        public string Charges { get; set; } = null!;
        public string Tenor { get; set; } = null!;
        public string Collaterals { get; set; } = null!;
        public string? Status { get; set; }
        public int? MWfId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
