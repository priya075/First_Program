using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserAssignedPortfolio
    {
        public int UapId { get; set; }
        public int UId { get; set; }
        public int PortfolioNo { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
