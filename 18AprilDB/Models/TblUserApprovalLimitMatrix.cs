using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserApprovalLimitMatrix
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public int RegnId { get; set; }
        public int ProgId { get; set; }
        public int MWfId { get; set; }
        public decimal ApprovingAmount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
