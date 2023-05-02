using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRiskBusinessRoleMapping
    {
        public int RbId { get; set; }
        public string? RiskRoleName { get; set; }
        public string? BusinessRoleName { get; set; }
    }
}
