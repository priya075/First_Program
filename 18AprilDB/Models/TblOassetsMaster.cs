using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOassetsMaster
    {
        public int Asid { get; set; }
        public string? AssetName { get; set; }
        public int? Aclsid { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? ParentAsid { get; set; }
    }
}
