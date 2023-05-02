using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblVendorMaster
    {
        public int VdId { get; set; }
        public int VtypeId { get; set; }
        public string VendorName { get; set; } = null!;
        public string VendorAgencyName { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Status { get; set; }
        public string? VendorCode { get; set; }
    }
}
