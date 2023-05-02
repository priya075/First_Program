using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblHelp
    {
        public int HelpId { get; set; }
        public string HelpText { get; set; } = null!;
        public string? Description { get; set; }
        public int ParentHelpId { get; set; }
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
