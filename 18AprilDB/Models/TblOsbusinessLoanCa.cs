using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsbusinessLoanCa
    {
        public int BlcaId { get; set; }
        public int Amid { get; set; }
        public int Cclid { get; set; }
        public string? BusinessLoanCaId { get; set; }
        public string? Blcaanswer { get; set; }
        public string? Blcatext { get; set; }
        public DateTime? Blcadate { get; set; }
        public string? Comments { get; set; }
        public string? Attachment { get; set; }
        public string? CheckListType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
