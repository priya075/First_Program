using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOspecialSectorCategory
    {
        public int Sscid { get; set; }
        public string? SpecialSectorCategory { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
