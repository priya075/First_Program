using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusCommitteeTracker
    {
        public int WfstcmtId { get; set; }
        public int? WfstappId { get; set; }
        public string? AppId { get; set; }
        public int? RId { get; set; }
        public string? RoleName { get; set; }
        public int? UId { get; set; }
        public int? CmtId { get; set; }
        public string? Vote { get; set; }
        public string? CommitteeName { get; set; }
        public bool? CommitteeStatus { get; set; }
        public DateTime? VotingDate { get; set; }
        public string? VotingCondition { get; set; }
        public int? YesCount { get; set; }
        public int? NoCount { get; set; }
        public int? Awccount { get; set; }
        public int? DiscCount { get; set; }
        public int? AllMemberCount { get; set; }
        public string? Comment { get; set; }
    }
}
