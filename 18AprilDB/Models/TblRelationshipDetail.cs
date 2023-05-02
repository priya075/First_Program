using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRelationshipDetail
    {
        public int Rdid { get; set; }
        public int Rtid { get; set; }
        public string FromId { get; set; } = null!;
        public string ToId { get; set; } = null!;
    }
}
