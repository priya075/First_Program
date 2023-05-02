using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmtitleDeed
    {
        public int DmTdId { get; set; }
        public int? DmId { get; set; }
        public int? DmDtypid { get; set; }
        public string? PropertyType { get; set; }
        public string? PropertyAddress { get; set; }
        public string? OwnerName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
