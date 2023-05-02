using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGlobalMcaorder
    {
        public int Id { get; set; }
        public string Cin { get; set; } = null!;
        public int CompanyId { get; set; }
        public string OrderReference { get; set; } = null!;
        public DateTime? OrderDateTime { get; set; }
        public string? OrderStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
