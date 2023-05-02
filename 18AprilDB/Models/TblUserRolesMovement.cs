using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserRolesMovement
    {
        public int Id { get; set; }
        public int? SourceUserId { get; set; }
        public int? TargetUserId { get; set; }
        public string? AccessName { get; set; }
        public int? AccessId { get; set; }
        public string? AccessType { get; set; }
        public DateTime? AssignedDate { get; set; }
        public bool? IsTemporary { get; set; }
        public DateTime? ValidUpto { get; set; }
        public bool? AssignSelectedRole { get; set; }
    }
}
