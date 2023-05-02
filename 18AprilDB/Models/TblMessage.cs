using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMessage
    {
        public int Id { get; set; }
        public string MessageGroup { get; set; } = null!;
        public string MessageKey { get; set; } = null!;
        public string MessageString { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
