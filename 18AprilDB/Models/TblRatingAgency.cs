using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRatingAgency
    {
        public int RaId { get; set; }
        public string? AgencyName { get; set; }
        public string? AgencyScale { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
