using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGlobalEntityCustomerRelationshipMaster
    {
        public int Id { get; set; }
        public string CtptUniqueId { get; set; } = null!;
        public string? Relationship { get; set; }
        public int? EntityId { get; set; }
        public int? EntityIdWi { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
