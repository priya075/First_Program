using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwIndustryHeirarchy
    {
        public int? HId { get; set; }
        public int? IndId { get; set; }
        public string? Name { get; set; }
        public int? Parent { get; set; }
        public string? IndCode { get; set; }
        public int? Hlevel { get; set; }
        public string? Hpath { get; set; }
        public string? Hpath1 { get; set; }
    }
}
