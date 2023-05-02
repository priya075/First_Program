using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOscommitteeMember
    {
        public int CmtMbId { get; set; }
        public int? CmtId { get; set; }
        public int? CmtMbrId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
