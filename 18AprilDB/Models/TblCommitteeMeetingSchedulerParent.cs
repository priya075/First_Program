﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCommitteeMeetingSchedulerParent
    {
        public int Id { get; set; }
        public string? MeetingId { get; set; }
        public string? CommitteeSet { get; set; }
        public string? MeetingDetails { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
