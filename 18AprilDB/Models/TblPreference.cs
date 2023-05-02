using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPreference
    {
        public int UId { get; set; }
        public int? MId { get; set; }
        public bool? OutOfOffice { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? TransferTo { get; set; }
        public bool IsDisclaimer { get; set; }
    }
}
