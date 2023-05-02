using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDoAmatrixSortOrder
    {
        public int DoAsid { get; set; }
        public string DoAtype { get; set; } = null!;
        public string DoAname { get; set; } = null!;
        public int MWfId { get; set; }
        public int SortOrder { get; set; }
    }
}
