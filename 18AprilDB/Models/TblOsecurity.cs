using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsecurity
    {
        public int SecId { get; set; }
        public string Securities { get; set; } = null!;
        public bool? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? ShowPanel { get; set; }
    }
}
