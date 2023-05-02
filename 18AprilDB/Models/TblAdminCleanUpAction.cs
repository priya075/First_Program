using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAdminCleanUpAction
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? ActionFrom { get; set; }
        public int? ActionObjectId { get; set; }
        public string? ActionObjectType { get; set; }
        public string? Operation { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
