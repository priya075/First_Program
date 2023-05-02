using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCautionAdvice
    {
        public string? CautionAdviceNo { get; set; }
        public string? NameOfBorrower { get; set; }
        public string? Category { get; set; }
        public string? CreditFacility { get; set; }
        public string? Address { get; set; }
        public string? Irregularity { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
