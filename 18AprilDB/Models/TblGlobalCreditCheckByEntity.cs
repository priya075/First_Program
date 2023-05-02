using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGlobalCreditCheckByEntity
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string? CheckType { get; set; }
        public string? Checks { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? EntityName { get; set; }
    }
}
