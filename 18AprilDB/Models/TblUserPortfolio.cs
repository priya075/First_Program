using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserPortfolio
    {
        public int UprtId { get; set; }
        public int UserId { get; set; }
        public int PrtId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
