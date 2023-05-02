using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMigCounterpartyIdentifier
    {
        public int Id { get; set; }
        public string? PrimaryAliasId { get; set; }
        public string? UcicId { get; set; }
        public string? Pan { get; set; }
        public string? Aadhar { get; set; }
    }
}
