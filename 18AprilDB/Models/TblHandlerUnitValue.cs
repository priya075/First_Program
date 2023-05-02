using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblHandlerUnitValue
    {
        public int Huid { get; set; }
        public string? Unit { get; set; }
        public int? Value { get; set; }
        public string? UnitDesc { get; set; }
    }
}
