using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFxRateIntegrationHistory
    {
        public string? HomeCcy { get; set; }
        public string? ForeignCcy { get; set; }
        public string? ConvUnits { get; set; }
        public string? Ratecode { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
