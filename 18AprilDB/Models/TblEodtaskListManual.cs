using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblEodtaskListManual
    {
        public int? Id { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
