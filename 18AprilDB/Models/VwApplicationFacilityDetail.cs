using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwApplicationFacilityDetail
    {
        public string? ApplicationId { get; set; }
        public string? UserId { get; set; }
        public string? PrimaryAliasId { get; set; }
        public string CounterPartyName { get; set; } = null!;
        public string? Department { get; set; }
        public DateTime SanctionDate { get; set; }
        public string? Parent { get; set; }
        public string? SubParent { get; set; }
        public string? Child { get; set; }
        public decimal? ProposedLimit { get; set; }
        public decimal? ExistingLimit { get; set; }
        public decimal? CurrentUtilization { get; set; }
        public decimal? Tenor { get; set; }
        public string Classification { get; set; } = null!;
    }
}
