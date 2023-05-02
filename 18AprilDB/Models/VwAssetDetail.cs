using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwAssetDetail
    {
        public int? Asid { get; set; }
        public string? AssetName { get; set; }
        public string? ParentAssetName { get; set; }
        public int? ParentAsid { get; set; }
        public string? Classification { get; set; }
        public int? Fclsid { get; set; }
        public string? TrxnProductType { get; set; }
        public int? SortOrder { get; set; }
        public int? ParentSortOrder { get; set; }
        public int? Aclsid { get; set; }
        public int? ParentAclsid { get; set; }
        public bool? IsDirect { get; set; }
        public string? SchmType { get; set; }
        public int? Polarity { get; set; }
        public int? Hlevel { get; set; }
        public string? HierarchicalPath { get; set; }
    }
}
