using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTrackingItemTypeSubTypeMapper
    {
        public int Id { get; set; }
        public int TraitmId { get; set; }
        public int TraitmsId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
