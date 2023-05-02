using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOprojectMaster
    {
        public int PmId { get; set; }
        public string ProjectId { get; set; } = null!;
        public int CtptId { get; set; }
        public string? XmlDetails { get; set; }
        public int? MWfId { get; set; }
        public DateTime ActionDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
