using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblXmltablesDetail
    {
        public int Xid { get; set; }
        public string? ObjectName { get; set; }
        public string? TableName { get; set; }
        public string? XmlField { get; set; }
        public string? IdField { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
