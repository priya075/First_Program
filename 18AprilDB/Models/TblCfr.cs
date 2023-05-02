using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCfr
    {
        public string? NameOfBank { get; set; }
        public string? FraudCaseNo { get; set; }
        public string? DateOfReporting { get; set; }
        public string? NameOfPerpetrator { get; set; }
        public string? PanOfPerpetrator { get; set; }
        public string? PartyAccountName { get; set; }
        public string? PerpetratorAccountAddress { get; set; }
        public string? ProprietorPartnerDirectorName { get; set; }
        public string? ProprietorPartnerDirectorAddress { get; set; }
        public string? AmountInvolvedRsInMn { get; set; }
        public string? AreaOfOperation { get; set; }
        public string? NatureOfFraud { get; set; }
        public string? TypeOfFraud { get; set; }
        public string? ModusOperandi { get; set; }
        public string? BriefHistory { get; set; }
        public string? FileName { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
