using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGlobalEntityDetailsMasterWithoutIdentifier
    {
        public int Id { get; set; }
        public string CtptUniqueId { get; set; } = null!;
        public string? Name { get; set; }
        public string? EntityType { get; set; }
        public string? MobileNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
