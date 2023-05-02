using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOpricingMaster
    {
        public int PmId { get; set; }
        public string PcngId { get; set; } = null!;
        public int CtptId { get; set; }
        public string? XmlDetails { get; set; }
        public int? MWfId { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
