using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAstarclassification
    {
        public int AstrcId { get; set; }
        public string AstrcText { get; set; } = null!;
        public string? AstrcDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
