using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinancialsUploadSourceSystem
    {
        public string? Token { get; set; }
        public string? BorrId { get; set; }
        public decimal? ModelId { get; set; }
        public DateTime? Stmtdt { get; set; }
        public decimal? AuditMethodId { get; set; }
        public string? SectionName { get; set; }
        public string? ItemName { get; set; }
        public decimal? Coarow { get; set; }
        public decimal? Value { get; set; }
        public decimal? Period { get; set; }
        public string? FinType { get; set; }
        public decimal? Stmtid { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
    }
}
