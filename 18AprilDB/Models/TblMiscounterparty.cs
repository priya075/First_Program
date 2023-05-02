using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMiscounterparty
    {
        public int WfstId { get; set; }
        public int CtptId { get; set; }
        public string? UniqueId { get; set; }
        public string? CounterPartyName { get; set; }
        public string? LeadRmId { get; set; }
        public string LeadRm { get; set; } = null!;
        public string? LeadRmEmployeeId { get; set; }
        public string? DepartmentName { get; set; }
    }
}
