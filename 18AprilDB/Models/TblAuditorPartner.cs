using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAuditorPartner
    {
        public int PartnerId { get; set; }
        public string? Name { get; set; }
        public string? MemberId { get; set; }
        public int? NumberOfFirms { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
