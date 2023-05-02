using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllTblOfacilityClsftypmapper
    {
        public int Facmapid { get; set; }
        public int Fclsid { get; set; }
        public int Factypid { get; set; }
        public int Fstypid { get; set; }
        public int? Fstprodid { get; set; }
        public string FacSubType { get; set; } = null!;
        public string FacilityType { get; set; } = null!;
        public string Expr1 { get; set; } = null!;
        public string FacProduct { get; set; } = null!;
    }
}
