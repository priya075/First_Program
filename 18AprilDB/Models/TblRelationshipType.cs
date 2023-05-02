using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRelationshipType
    {
        public int Rtid { get; set; }
        public string RelationshipType { get; set; } = null!;
        public string RelationshipTypeDesc { get; set; } = null!;
        public string FromTable { get; set; } = null!;
        public string FromTableColumn { get; set; } = null!;
        public string FromTableDisplayColumn { get; set; } = null!;
        public string ToTable { get; set; } = null!;
        public string ToTableColumn { get; set; } = null!;
        public string ToTableDisplayColumn { get; set; } = null!;
        public int OtherSideRtid { get; set; }
    }
}
