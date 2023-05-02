using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGlobalIdentifiersDetailsMaster
    {
        public int Id { get; set; }
        public int IdentifierId { get; set; }
        public string IdentifierName { get; set; } = null!;
        public string IdentifierValue { get; set; } = null!;
        public DateTime? IdentifierExpiry { get; set; }
        public string? Name { get; set; }
        public string? Data { get; set; }
        public bool? IsValidated { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
