using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblXmltablesNodesField
    {
        public int XnodeFid { get; set; }
        public int? Xid { get; set; }
        public int? XnodeId { get; set; }
        public string? XmlfieldName { get; set; }
        public string? XmlfieldDatatype { get; set; }
        public string? TableFieldName { get; set; }
        public string? FieldDescription { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsInsert { get; set; }
        public bool? IsXml { get; set; }
    }
}
