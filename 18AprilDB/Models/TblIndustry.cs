using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblIndustry
    {
        public int IndId { get; set; }
        public string? IndustryCode { get; set; }
        public string? Industry { get; set; }
        public string? SubSectorCode { get; set; }
        public string? SubSector { get; set; }
        public string? SectorCode { get; set; }
        public string? Sector { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
        public bool? IsCaution { get; set; }
        public bool? IsNegative { get; set; }
        public int? Marking { get; set; }
    }
}
