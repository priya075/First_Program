using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserMachinDetailsHistory
    {
        public int Umhistid { get; set; }
        public int? Umid { get; set; }
        public string? UserId { get; set; }
        public string? RemoteIp { get; set; }
        public string? Dnsname { get; set; }
        public string? Language { get; set; }
        public string? Country { get; set; }
        public string? CountryIsocode { get; set; }
        public string? GeoCode { get; set; }
        public DateTime? AccessDate { get; set; }
        public DateTime? LoggedInTime { get; set; }
        public DateTime? LoggedOutTime { get; set; }
    }
}
