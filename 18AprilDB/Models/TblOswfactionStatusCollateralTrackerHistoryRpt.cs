using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusCollateralTrackerHistoryRpt
    {
        public int Id { get; set; }
        public int WfstcolId { get; set; }
        public int WfstappId { get; set; }
        public string ColId { get; set; } = null!;
        public int WfaId { get; set; }
        public int RId { get; set; }
        public int MId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public string? XmlCollateral { get; set; }
        public string? Status { get; set; }
        public string? Status2 { get; set; }
        public string? Status3 { get; set; }
        public int? MWfId { get; set; }
    }
}
