using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcalenderMaster
    {
        public int CalId { get; set; }
        public string? Region { get; set; }
        public DateTime? OfficeStartTime { get; set; }
        public DateTime? OfficeEndTime { get; set; }
        public string? WeekendDays { get; set; }
    }
}
