using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwAssetProductMap
    {
        public string? AssetName { get; set; }
        public string AssetClassification { get; set; } = null!;
        public string? ProductName { get; set; }
        public int AssetId { get; set; }
        public int? AssetClassificationId { get; set; }
        public int ProductId { get; set; }
        public int? SortOrder { get; set; }
    }
}
