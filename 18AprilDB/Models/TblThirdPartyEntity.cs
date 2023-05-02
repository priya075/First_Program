using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblThirdPartyEntity
    {
        public string? SrNo { get; set; }
        public string? NameOfThirdPartyEntity { get; set; }
        public string? RegisteredOfficeAddress { get; set; }
        public string? RegistrationNoPanOfTheProprietorPartnersDirectorsFirm { get; set; }
        public string? NameOfTheProprietorPartnersDirectors { get; set; }
        public string? MainLineOfBusiness { get; set; }
        public string? LineOfBusinessInWhichTheBankHadUsedTheTpe { get; set; }
        public string? ReasonForPuttingTheNameInTheCautionaryList { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
