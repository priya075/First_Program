using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class Tblexternalcustomer
    {
        public int Finacleid { get; set; }
        public string Customername { get; set; } = null!;
        public string? Address { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string? Legaltypedetail { get; set; }
        public string? Relationshipmanager { get; set; }
    }
}
