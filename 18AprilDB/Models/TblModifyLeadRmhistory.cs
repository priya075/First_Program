using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblModifyLeadRmhistory
    {
        public int Id { get; set; }
        public string? UniqueId { get; set; }
        public string? NewLeadRm { get; set; }
        public int? LastWfstId { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
