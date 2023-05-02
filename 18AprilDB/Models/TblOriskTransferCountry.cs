using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOriskTransferCountry
    {
        public int Rtcid { get; set; }
        public int? Afid { get; set; }
        public int? Country { get; set; }
        public int? RiskPercentage { get; set; }
    }
}
