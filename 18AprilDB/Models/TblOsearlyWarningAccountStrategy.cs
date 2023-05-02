using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsearlyWarningAccountStrategy
    {
        public int ActstrId { get; set; }
        public int Amid { get; set; }
        public string? EwsId { get; set; }
        public string? ActstrText { get; set; }
        public DateTime? ActstrDate { get; set; }
        public string? Comments { get; set; }
        public string? Attachment { get; set; }
        public string? CheckListType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
