using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRbidefaulterChecklist
    {
        public string? NameOfDefaulters { get; set; }
        public string? Address { get; set; }
        public string? NatureOfIrregularities { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
