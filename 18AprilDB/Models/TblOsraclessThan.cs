using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsraclessThan
    {
        public int RacltId { get; set; }
        public int Amid { get; set; }
        public int Cclid { get; set; }
        public string? RaclessThanId { get; set; }
        public string? Racltanswer { get; set; }
        public string? Raclttext { get; set; }
        public DateTime? Racltdate { get; set; }
        public string? Comments { get; set; }
        public string? Attachment { get; set; }
        public string? CheckListType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
