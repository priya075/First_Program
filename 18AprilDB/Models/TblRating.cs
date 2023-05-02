using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRating
    {
        public int RtId { get; set; }
        public int? RaId { get; set; }
        public string? Rating { get; set; }
        public string? SortOrder { get; set; }
        public string? InternalMapRating { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
