using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblInterfacetablesDetail
    {
        public int Itid { get; set; }
        public int Ifid { get; set; }
        public string TableName { get; set; } = null!;
        public string SourceTableName { get; set; } = null!;
        public string KeyField { get; set; } = null!;
        public string SourceKeyField { get; set; } = null!;
        public string? TableDesc { get; set; }
        public string? XmlNode { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
