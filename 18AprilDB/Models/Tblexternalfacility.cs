using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class Tblexternalfacility
    {
        public int Customerfinacleid { get; set; }
        public string Finaclelimitid { get; set; } = null!;
        public string Facilitytype { get; set; } = null!;
        public string Facilitysubtype { get; set; } = null!;
        public int Limitamount { get; set; }
        public string Limitcurrency { get; set; } = null!;
        public DateTime? Limitexpirydate { get; set; }
        public int? Limittenor { get; set; }
    }
}
