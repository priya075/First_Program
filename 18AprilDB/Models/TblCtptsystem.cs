using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptsystem
    {
        public int CtSaId { get; set; }
        public string? SystemName { get; set; }
        public bool? IsMultipleAllowed { get; set; }
    }
}
