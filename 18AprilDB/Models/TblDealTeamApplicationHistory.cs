using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDealTeamApplicationHistory
    {
        public int Histdtid { get; set; }
        public int? Dtid { get; set; }
        public string? AppId { get; set; }
        public int? CtptId { get; set; }
        public int? UId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
