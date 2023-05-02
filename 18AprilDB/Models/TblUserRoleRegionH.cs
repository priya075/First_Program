using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserRoleRegionH
    {
        public int UrrId { get; set; }
        public int UrId { get; set; }
        public int RegnId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? InsertedOn { get; set; }
    }
}
