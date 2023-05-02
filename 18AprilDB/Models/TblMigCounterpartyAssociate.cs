using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMigCounterpartyAssociate
    {
        public int Id { get; set; }
        public string? MainCust { get; set; }
        public string? CodCust { get; set; }
        public string? UcicId { get; set; }
        public string? CoBorrower { get; set; }
        public string? AssociateName { get; set; }
        public string? IndiNonIndi { get; set; }
        public string? MatchWthCust { get; set; }
        public string? DoeDob { get; set; }
        public string? Pan { get; set; }
        public string? CommAddress { get; set; }
        public string? CommCity { get; set; }
        public string? CommState { get; set; }
        public string? CommPincode { get; set; }
        public string? CommCountry { get; set; }
    }
}
