using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWorkflowRoleChecklist
    {
        public int Wfclid { get; set; }
        public int RId { get; set; }
        public string Statement { get; set; } = null!;
        public bool Status { get; set; }
    }
}
