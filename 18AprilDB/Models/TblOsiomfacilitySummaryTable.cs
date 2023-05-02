using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsiomfacilitySummaryTable
    {
        public int IomfstId { get; set; }
        public int Amid { get; set; }
        public string? FactabId { get; set; }
        public string? Aggrttype { get; set; }
        public decimal Limit { get; set; }
        public decimal? Outstanding { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
