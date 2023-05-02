using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAuditedMethod
    {
        public int Id { get; set; }
        public string AuditmethodName { get; set; } = null!;
        public int? MstSourceId { get; set; }
        public int? PriorityOrder { get; set; }
        public string? ShortName { get; set; }
    }
}
