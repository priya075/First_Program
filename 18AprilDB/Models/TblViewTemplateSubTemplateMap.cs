using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblViewTemplateSubTemplateMap
    {
        public int Mapid { get; set; }
        public int TmpSubId { get; set; }
        public int TmpId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string SubTemplateDesc { get; set; } = null!;
        public bool HasFinTable { get; set; }
        public bool HasCommentary { get; set; }
        public bool Status { get; set; }
        public string? FinReturnType { get; set; }
        public int? SortOrder { get; set; }
    }
}
