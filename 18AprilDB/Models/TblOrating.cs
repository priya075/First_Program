using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOrating
    {
        public int OrtId { get; set; }
        public string AgencyName { get; set; } = null!;
        public string Rating { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
