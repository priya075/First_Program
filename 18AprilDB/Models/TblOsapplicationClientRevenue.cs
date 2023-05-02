using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsapplicationClientRevenue
    {
        public int Acrid { get; set; }
        public int Amid { get; set; }
        public string? Paramaters { get; set; }
        public decimal? Cyforecast { get; set; }
        public decimal? Crybudget { get; set; }
        public decimal? PyuponYtd { get; set; }
        public decimal? ForecastUponBudget { get; set; }
    }
}
