using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsapplicationComplianceChecklist
    {
        public int Acclid { get; set; }
        public int Amid { get; set; }
        public int Cclid { get; set; }
        public string? ChkId { get; set; }
        public bool? Chklanswer { get; set; }
        public string CheckListTextUser { get; set; } = null!;
        public DateTime? Chkldate { get; set; }
        public string Comments { get; set; } = null!;
        public string Attachment { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
