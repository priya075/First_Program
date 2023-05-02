using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptsalesReject
    {
        public int Id { get; set; }
        public string? CounterpartyName { get; set; }
        public string? UniqueId { get; set; }
        public string? Pan { get; set; }
        public string? ReasonOfSalesReject { get; set; }
        public int? UId { get; set; }
        public DateTime? SalesRejectDate { get; set; }
        public string? BusinessSegment { get; set; }
        public int? Industry { get; set; }
    }
}
