using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwModule
    {
        public int MId { get; set; }
        public string? Name { get; set; }
        public bool? Status1 { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
