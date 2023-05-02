using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllWorkflowsAction
    {
        public int WfaId { get; set; }
        public string ActionName { get; set; } = null!;
        public int? RId { get; set; }
        public string RoleName { get; set; } = null!;
        public int? MId { get; set; }
        public string? Module { get; set; }
        public int? MWfId { get; set; }
        public string ModuleWorkFlow { get; set; } = null!;
        public string? Description { get; set; }
        public int? NextRole { get; set; }
        public bool Active { get; set; }
        public int? CommitteeId { get; set; }
        public bool? IsCommitteeRelated { get; set; }
        public bool? IsActingRolePartOfComm { get; set; }
        public bool? IsVisible { get; set; }
        public string? ActionType { get; set; }
        public int? ActionOrder { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
