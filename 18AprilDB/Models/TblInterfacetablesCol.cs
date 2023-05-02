using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblInterfacetablesCol
    {
        public int Icid { get; set; }
        public int Itid { get; set; }
        public int Ifid { get; set; }
        public string FieldName { get; set; } = null!;
        public string SourceFieldName { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public string? FieldDescription { get; set; }
        public bool IsActive { get; set; }
        public int? SortOrder { get; set; }
        public bool IsInsert { get; set; }
        public bool IsEditable { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsExt { get; set; }
    }
}
