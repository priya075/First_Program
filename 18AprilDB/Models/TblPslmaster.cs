using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPslmaster
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public int Sector { get; set; }
        public int IndustryId { get; set; }
        public string Pslcategory { get; set; } = null!;
        public string? Pslcode { get; set; }
        public string? Psldescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
