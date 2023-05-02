using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRoipickerApproval
    {
        public int Id { get; set; }
        public string Verticle { get; set; } = null!;
        public int Program { get; set; }
        public int Funded { get; set; }
        public int ProductCategory { get; set; }
        public int Secured { get; set; }
        public string PslType { get; set; } = null!;
        public int ApprovingAuthority { get; set; }
        public decimal RangeFrom { get; set; }
        public decimal RangeTo { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; } = null!;
    }
}
