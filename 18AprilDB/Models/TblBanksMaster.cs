using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBanksMaster
    {
        public int BnkId { get; set; }
        public string BankName { get; set; } = null!;
        public int? BankInternalRating { get; set; }
        public int? BankType { get; set; }
        public bool? IsBorrowingCustomer { get; set; }
        public int? LinkedCustomer { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
