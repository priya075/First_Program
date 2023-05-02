﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCndmowfactionStatusConditionsItemsTracker
    {
        public int WfstcmoiId { get; set; }
        public int SchId { get; set; }
        public string ConditionId { get; set; } = null!;
        public string CndmoiId { get; set; } = null!;
        public string ConditionType { get; set; } = null!;
        public int CtptId { get; set; }
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlDetails { get; set; }
        public int MWfId { get; set; }
        public DateTime? AcknowledgeDate { get; set; }
    }
}
