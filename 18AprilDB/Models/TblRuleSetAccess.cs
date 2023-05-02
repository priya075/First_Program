using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRuleSetAccess
    {
        public int RsaId { get; set; }
        public string MachineName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Apikey { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
