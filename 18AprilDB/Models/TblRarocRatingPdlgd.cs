using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRarocRatingPdlgd
    {
        public int BaselRatingId { get; set; }
        public string Rating { get; set; } = null!;
        public decimal Pd { get; set; }
        public decimal Lgd { get; set; }
        public bool? IsActive { get; set; }
    }
}
