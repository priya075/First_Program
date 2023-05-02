using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGlobalEntityDetailsMaster
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Pan { get; set; }
        public string? Aadhaar { get; set; }
        public string? MobileNumber { get; set; }
        public DateTime? IdentifierExpiry { get; set; }
        public bool? IsActive { get; set; }
        public string? Data { get; set; }
        public string? OtherEntityDetails { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? EntityType { get; set; }
    }
}
