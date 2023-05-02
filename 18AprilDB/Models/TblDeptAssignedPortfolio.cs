using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDeptAssignedPortfolio
    {
        public int? DapId { get; set; }
        public int? DptId { get; set; }
        public int? PortfolioNo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
