using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBankType
    {
        public int BtId { get; set; }
        public string? BankType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
