using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFraudulent
    {
        public string? SrNo { get; set; }
        public string? NameOfThePartyInWhoseAccountTheFraudOccurred { get; set; }
        public string? Address { get; set; }
        public string? NatureOfFraud { get; set; }
        public string? ModusOperandi { get; set; }
        public string? SeriousIrregularitiesObserved { get; set; }
        public string? CausativeFactors { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
