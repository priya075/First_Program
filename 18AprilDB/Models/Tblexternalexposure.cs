using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class Tblexternalexposure
    {
        public int Customerfinacleid { get; set; }
        public string Externalfacilityid { get; set; } = null!;
        public string Transactionid { get; set; } = null!;
        public string Exposureamount { get; set; } = null!;
        public string Exposurecurrency { get; set; } = null!;
        public DateTime? Exposurestartdate { get; set; }
        public DateTime? Exposureenddate { get; set; }
    }
}
