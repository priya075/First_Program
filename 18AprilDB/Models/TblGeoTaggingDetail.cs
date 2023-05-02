using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGeoTaggingDetail
    {
        public int GtId { get; set; }
        public string? GeoId { get; set; }
        public int? UId { get; set; }
        public string? GeoDetails { get; set; }
        public byte[]? LocationImage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
