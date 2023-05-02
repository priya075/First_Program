using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsearlyWarningQuestionaire
    {
        public int QueId { get; set; }
        public int Amid { get; set; }
        public int Cclid { get; set; }
        public string? EwsId { get; set; }
        public string? CheckListType { get; set; }
        public string? Qewstext { get; set; }
        public string? Qewsanswer { get; set; }
        public string? Comments { get; set; }
        public DateTime? Qewsdate { get; set; }
        public string? Attachment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
