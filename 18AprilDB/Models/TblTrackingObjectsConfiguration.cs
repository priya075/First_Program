using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTrackingObjectsConfiguration
    {
        public int TioId { get; set; }
        public int ObjectId { get; set; }
        public string ObjectName { get; set; } = null!;
        public string ObjectNamespace { get; set; } = null!;
        public string ObjectClass { get; set; } = null!;
        public string ObjectTableName { get; set; } = null!;
        public string? ObjectWfprefix { get; set; }
        public int ParentTioId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
