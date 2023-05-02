using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOspurposeOfCa
    {
        public int Pid { get; set; }
        public string Purpose { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
