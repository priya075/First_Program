using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRemscountryWiseExposure
    {
        public string? ExposureDate { get; set; }
        public string? CountrySwiftCode { get; set; }
        public string? Name { get; set; }
        public string? ToAllocated { get; set; }
        public string? ToUtilized { get; set; }
        public string? ToAvailable { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
