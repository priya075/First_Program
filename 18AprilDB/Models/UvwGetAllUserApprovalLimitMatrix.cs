using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllUserApprovalLimitMatrix
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public string? Userid { get; set; }
        public int RegnId { get; set; }
        public string? RegionName { get; set; }
        public int ProgId { get; set; }
        public int MWfId { get; set; }
        public string? Wfname { get; set; }
        public decimal ApprovingAmount { get; set; }
        public DateTime? Createdon { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string? Modifiedby { get; set; }
    }
}
