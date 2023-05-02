using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwUserPermission
    {
        public int UId { get; set; }
        public Guid? ActivityId { get; set; }
        public int? CId { get; set; }
        public string? UserId { get; set; }
        public string Password { get; set; } = null!;
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public string? EmailId { get; set; }
        public int UpId { get; set; }
        public string? Description { get; set; }
        public int MId { get; set; }
        public string? Name { get; set; }
        public bool? ModuleStatus { get; set; }
    }
}
