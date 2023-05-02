using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBranch
    {
        public int BrId { get; set; }
        public string? BranchName { get; set; }
        public string? Address { get; set; }
        public string? BranchCity { get; set; }
        public int? Region { get; set; }
        public int? UId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
