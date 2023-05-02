using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDefaultLimitMaster
    {
        public int Id { get; set; }
        public string? LimitReference { get; set; }
        public string? LimitReferenceDescription { get; set; }
        public int? Classification { get; set; }
    }
}
