using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExposuresBatchDetail
    {
        public int Id { get; set; }
        public DateTime? RunDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public DateTime? ReportDate { get; set; }
    }
}
