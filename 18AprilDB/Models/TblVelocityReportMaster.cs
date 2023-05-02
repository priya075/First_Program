using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblVelocityReportMaster
    {
        public string? Zone { get; set; }
        public string? Cluster { get; set; }
        public string? Branch { get; set; }
        public string? AccountNumber { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? AccountOpenDate { get; set; }
        public string? Limit { get; set; }
        public string? Balance { get; set; }
        public string? VintagecmCurrMonth { get; set; }
        public string? VintagepmCurrMonth { get; set; }
        public string? VintagecmCurrMonthPoints { get; set; }
        public string? VintagepmCurrMonthPoints { get; set; }
        public string? VintagecmPrevMonth { get; set; }
        public string? VintagepmPrevMonth { get; set; }
        public string? VintagecmPrevMonthPoints { get; set; }
        public string? VintagepmPrevMonthPoints { get; set; }
        public string? Curmnth { get; set; }
        public string? Premnth { get; set; }
        public string? Solid { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
