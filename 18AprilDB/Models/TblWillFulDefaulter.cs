using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWillFulDefaulter
    {
        public string? SrNo { get; set; }
        public string? Branch { get; set; }
        public string? Borrower { get; set; }
        public string? RegisteredAddress { get; set; }
        public string? NameOfTheDefaultorDirectorProprietorPartners { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
