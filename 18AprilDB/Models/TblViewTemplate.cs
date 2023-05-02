using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblViewTemplate
    {
        public int TmpId { get; set; }
        public string? TemplateName { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? TemplateDesc { get; set; }
    }
}
