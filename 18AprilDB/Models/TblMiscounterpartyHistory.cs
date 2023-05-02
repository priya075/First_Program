using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMiscounterpartyHistory
    {
        public int? WfstId { get; set; }
        public int? CtptId { get; set; }
        public string? UniqueId { get; set; }
        public string? CounterPartyName { get; set; }
        public int? LeadRmId { get; set; }
        public string? LeadRm { get; set; }
        public string? LeadRmEmployeeId { get; set; }
        public string? DepartmentName { get; set; }
    }
}
