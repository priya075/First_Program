using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcollateralTypsubtypmapper
    {
        public int Colmapid { get; set; }
        public int Coltypid { get; set; }
        public int Cstypid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
