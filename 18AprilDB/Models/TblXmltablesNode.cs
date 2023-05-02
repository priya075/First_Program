using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblXmltablesNode
    {
        public int XnodeId { get; set; }
        public int? Xid { get; set; }
        public string? XmlNode { get; set; }
        public string? TargetTable { get; set; }
        public string? KeyField { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsEditable { get; set; }
        public string? ParentTableName { get; set; }
        public string? ParentRefCol { get; set; }
        public string? RefCol { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
