using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacUserCounterparty
    {
        public int Fucid { get; set; }
        public int CtptId { get; set; }
        public int Afid { get; set; }
        public string Facid { get; set; } = null!;
    }
}
