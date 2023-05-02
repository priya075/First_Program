using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDedupetablesDetail
    {
        public int Duid { get; set; }
        public string ObjectName { get; set; } = null!;
        public string SourceTableName { get; set; } = null!;
        public bool IsXmlcolumn { get; set; }
        public string? XmlField { get; set; }
        public string? IdField { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }
        public string SourceKeyColumn { get; set; } = null!;
        public string? ParentTableName { get; set; }
        public string? ParentTableRefColumn { get; set; }
        public string? FilterCondition { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
