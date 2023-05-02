using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwCommitteeForRole
    {
        public int CmtId { get; set; }
        public string? CommitteeName { get; set; }
        public string? CommitteeFlowStyle { get; set; }
        public string? CommitteeActionStyle { get; set; }
        public string? CommitteeDecisionStyle { get; set; }
        public int? CommitteeSecretary { get; set; }
        public bool? Active { get; set; }
        public int? CmtWfId { get; set; }
        public int? CmtModuleId { get; set; }
        public string? Sname { get; set; }
        public string? Userid { get; set; }
        public int RId { get; set; }
        public string RoleName { get; set; } = null!;
    }
}
