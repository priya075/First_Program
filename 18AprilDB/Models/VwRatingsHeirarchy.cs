using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwRatingsHeirarchy
    {
        public int HId { get; set; }
        public int RtId { get; set; }
        public string? Name { get; set; }
        public int Parent { get; set; }
        public int Hlevel { get; set; }
        public string Hpath { get; set; } = null!;
        public string Hpath1 { get; set; } = null!;
    }
}
