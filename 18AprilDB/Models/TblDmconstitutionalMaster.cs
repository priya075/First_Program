using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmconstitutionalMaster
    {
        public int QueId { get; set; }
        public int Amid { get; set; }
        public int? CtptId { get; set; }
        public string? ConstitutionId { get; set; }
        public string? IsStandard { get; set; }
        public string? Text { get; set; }
        public string? IsCommunicated { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
