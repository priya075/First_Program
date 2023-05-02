using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTempLead
    {
        public int TlId { get; set; }
        public string UniqueId { get; set; } = null!;
        public string? LeadDetails { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
