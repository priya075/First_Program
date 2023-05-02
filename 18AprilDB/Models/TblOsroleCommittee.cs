using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsroleCommittee
    {
        public int CmtId { get; set; }
        public string? CommitteeName { get; set; }
        public string? CommitteeFlowStyle { get; set; }
        public string? CommitteeActionStyle { get; set; }
        public string? CommitteeDecisionStyle { get; set; }
        public int? CommitteeSecretary { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? CmtModuleId { get; set; }
        public int? CmtWfId { get; set; }
        public int? OutOfOffice { get; set; }
        public int? CommitteeChairmanRole { get; set; }
        public int? CommitteeVchairmanRole { get; set; }
    }
}
