using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptidentifiersDetail
    {
        public int Id { get; set; }
        public string CtptId { get; set; } = null!;
        public int? IdentifierId { get; set; }
        public string? IdentifierValue { get; set; }
        public DateTime? IdentifierExpiryDate { get; set; }
    }
}
