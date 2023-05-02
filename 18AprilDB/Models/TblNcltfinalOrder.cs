using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblNcltfinalOrder
    {
        public string? Date { get; set; }
        public string? OrderDate { get; set; }
        public string? Type { get; set; }
        public string? Bench { get; set; }
        public string? CpCaNo { get; set; }
        public string? Section { get; set; }
        public string? NameOfParties { get; set; }
        public string? SourceLink { get; set; }
        public string? IndusindHitsAppellant { get; set; }
        public string? IndusindHitsRespondant { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
