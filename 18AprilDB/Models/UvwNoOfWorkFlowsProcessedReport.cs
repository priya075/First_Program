using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwNoOfWorkFlowsProcessedReport
    {
        public int CtptId { get; set; }
        public DateTime ActionDate { get; set; }
        public string CounterPartyName { get; set; } = null!;
        public string Wfname { get; set; } = null!;
        public int? MWfId { get; set; }
        public string CountOfApplication { get; set; } = null!;
    }
}
