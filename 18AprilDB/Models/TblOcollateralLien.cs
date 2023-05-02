using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcollateralLien
    {
        public int ClenId { get; set; }
        public int AcId { get; set; }
        public string Colid { get; set; } = null!;
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountWithBank { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
