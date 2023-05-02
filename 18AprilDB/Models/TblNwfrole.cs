using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblNwfrole
    {
        public int NwfrId { get; set; }
        public string RoleType { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public string? RoleDesc { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Template { get; set; }
    }
}
