using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllrating
    {
        public int RtId { get; set; }
        public int? RaId { get; set; }
        public string? AgencyName { get; set; }
        public string? AgencyScale { get; set; }
        public string? Rating { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SortOrder { get; set; }
        public string? InternalMapRating { get; set; }
    }
}
