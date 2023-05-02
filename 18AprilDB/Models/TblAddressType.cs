using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAddressType
    {
        public int AtId { get; set; }
        public string? AddressType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
