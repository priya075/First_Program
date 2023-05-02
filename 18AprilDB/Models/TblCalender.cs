using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCalender
    {
        public int Id { get; set; }
        public int? CalId { get; set; }
        public DateTime? CDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsWeekend { get; set; }
        public bool? IsHoliday { get; set; }
    }
}
