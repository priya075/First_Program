using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblValuer
    {
        public int Id { get; set; }
        public string? ValuerId { get; set; }
        public string? ValuerCode { get; set; }
        public string? ValuerName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
