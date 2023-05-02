using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptriskSensitivity
    {
        public int Id { get; set; }
        public string? CtptId { get; set; }
        public string? RiskSensitivity { get; set; }
    }
}
