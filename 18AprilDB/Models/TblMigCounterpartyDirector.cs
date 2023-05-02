using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMigCounterpartyDirector
    {
        public int Id { get; set; }
        public string? MainCust { get; set; }
        public string? CodCust { get; set; }
        public string? UcicId { get; set; }
        public string? Salutation { get; set; }
        public string? Name { get; set; }
        public string? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? AddressCountry { get; set; }
        public string? City { get; set; }
        public string? Pin { get; set; }
        public string? IsKmp { get; set; }
        public string? StakeholerType { get; set; }
        public string? Others { get; set; }
        public string? Pan { get; set; }
        public string? Adhar { get; set; }
        public string? IsAuthorizedSignatory { get; set; }
        public string? CoBorrower { get; set; }
    }
}
