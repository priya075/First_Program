using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBankValuesMaster
    {
        public int Id { get; set; }
        public int BuId { get; set; }
        public int RegnId { get; set; }
        public string AuValueName { get; set; } = null!;
        public string AuValueCode { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
