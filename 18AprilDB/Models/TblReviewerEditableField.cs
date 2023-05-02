using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblReviewerEditableField
    {
        public int Rvef { get; set; }
        public int? MId { get; set; }
        public string? ParentFieldName { get; set; }
        public string? ChildFieldName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
