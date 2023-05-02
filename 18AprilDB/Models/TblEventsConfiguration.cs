using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblEventsConfiguration
    {
        public int Id { get; set; }
        public string Ueid { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
