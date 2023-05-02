using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptidentificationMaster
    {
        public int Id { get; set; }
        public string? Identification { get; set; }
        public string? RegEx { get; set; }
        public bool IsMultipleAllowed { get; set; }
    }
}
