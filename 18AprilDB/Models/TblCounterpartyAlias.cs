using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCounterpartyAlias
    {
        public int CtCaId { get; set; }
        public string CtptId { get; set; } = null!;
        public int CtSaId { get; set; }
        public string SystemName { get; set; } = null!;
        public string CounterpartyAlias { get; set; } = null!;
    }
}
