using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsearlyWarningAccountPosition
    {
        public int ActposId { get; set; }
        public int Amid { get; set; }
        public string? EwsId { get; set; }
        public string? Aggrttype { get; set; }
        public decimal? Limit { get; set; }
        public decimal? Outstanding { get; set; }
        public decimal? InPdExcess { get; set; }
        public decimal? DayOverdue { get; set; }
        public string? Comments { get; set; }
        public string? Attachment { get; set; }
        public string? CheckListType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
