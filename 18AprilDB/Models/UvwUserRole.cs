using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwUserRole
    {
        public int UId { get; set; }
        public string? UserId { get; set; }
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public int UrId { get; set; }
        public string? Description { get; set; }
        public int RId { get; set; }
        public string RoleName { get; set; } = null!;
        public int? CId { get; set; }
        public int MWfId { get; set; }
        public string Wfname { get; set; } = null!;
        public int MId { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
    }
}
