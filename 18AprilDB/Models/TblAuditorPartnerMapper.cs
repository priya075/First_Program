using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAuditorPartnerMapper
    {
        public int MapperId { get; set; }
        public int? AuditorId { get; set; }
        public int? PartnerId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
