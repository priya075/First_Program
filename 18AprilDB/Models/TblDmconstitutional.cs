using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmconstitutional
    {
        public int ConstId { get; set; }
        public string? ConstName { get; set; }
        public string? ConstDesc { get; set; }
        public bool? New { get; set; }
    }
}
