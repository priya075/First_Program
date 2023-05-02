using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOscomplianceChecklist
    {
        public int Cclid { get; set; }
        public string CheckListType { get; set; } = null!;
        public string CheckListText { get; set; } = null!;
        public string? Chklparam { get; set; }
        public DateTime? Chkldate { get; set; }
        public bool? IsControlVisible { get; set; }
        public string? CheckListTypeDesc { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? HasAttachment { get; set; }
    }
}
