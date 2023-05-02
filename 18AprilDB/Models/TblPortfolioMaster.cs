using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolioMaster
    {
        public int PrtId { get; set; }
        public string? PortfolioName { get; set; }
        public string? PortfolioDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
