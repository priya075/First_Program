using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCountryHeirarchy
    {
        public int HId { get; set; }
        public int? CtId { get; set; }
        public string? Name { get; set; }
        public int? Parent { get; set; }
    }
}
