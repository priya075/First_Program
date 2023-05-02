using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigIdentifierEnc
    {
        public int Id { get; set; }
        public int? RecordId { get; set; }
        public string? RecordType { get; set; }
        public string? IdentifierType { get; set; }
        public string? IdentifierValue { get; set; }
        public string? IdentifierValueEnc { get; set; }
    }
}
