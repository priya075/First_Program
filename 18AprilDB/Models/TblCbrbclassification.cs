using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCbrbclassification
    {
        public int Cbrbid { get; set; }
        public string? Name { get; set; }
        public int? MstSourceId { get; set; }
    }
}
