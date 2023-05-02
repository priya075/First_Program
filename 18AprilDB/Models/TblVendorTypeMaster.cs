using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblVendorTypeMaster
    {
        public int VtypeId { get; set; }
        public string? VendorType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? Status { get; set; }
    }
}
