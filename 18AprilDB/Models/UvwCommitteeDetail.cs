using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwCommitteeDetail
    {
        public int CmtId { get; set; }
        public string? CommitteeName { get; set; }
        public string? CommitteeActionStyle { get; set; }
        public string? CommitteeDecisionStyle { get; set; }
        public int? CommitteeSecretary { get; set; }
        public bool? Active { get; set; }
        public string? Sname { get; set; }
        public string? Userid { get; set; }
    }
}
