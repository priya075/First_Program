using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusSecuritiesTracker
    {
        public int WfstsecId { get; set; }
        public int WfstappId { get; set; }
        public int WfaId { get; set; }
        public int RId { get; set; }
        public int MId { get; set; }
        public string SecId { get; set; } = null!;
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public string? XmlSecurities { get; set; }
        public string? Status { get; set; }
        public int? MWfId { get; set; }
        public string? Status2 { get; set; }
        public string? Status3 { get; set; }
    }
}
