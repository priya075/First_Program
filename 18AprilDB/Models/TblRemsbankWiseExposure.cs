using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRemsbankWiseExposure
    {
        public string? ExposureDate { get; set; }
        public string? BankSwiftCode { get; set; }
        public string? Name { get; set; }
        public string? ToAllocated { get; set; }
        public string? ToUtilized { get; set; }
        public string? ToAvailable { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
