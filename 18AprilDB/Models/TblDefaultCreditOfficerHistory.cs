using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDefaultCreditOfficerHistory
    {
        public int Id { get; set; }
        public int DcoId { get; set; }
        public int FileId { get; set; }
        public string? RmId { get; set; }
        public string? RmName { get; set; }
        public string? CreditId { get; set; }
        public string? CreditName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
