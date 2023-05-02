using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOperationDiary
    {
        public int OperationDiaryId { get; set; }
        public int CtptId { get; set; }
        public string? OperationDiaryXml { get; set; }
        public int? Activity { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
