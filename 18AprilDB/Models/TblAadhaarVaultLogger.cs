using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAadhaarVaultLogger
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
