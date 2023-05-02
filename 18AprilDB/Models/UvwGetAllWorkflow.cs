using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllWorkflow
    {
        public int MWfId { get; set; }
        public int? CId { get; set; }
        public int? MId { get; set; }
        public int? WfobjectId { get; set; }
        public string Wfname { get; set; } = null!;
        public string? Description { get; set; }
        public bool? Status { get; set; }
        public string? Module { get; set; }
    }
}
