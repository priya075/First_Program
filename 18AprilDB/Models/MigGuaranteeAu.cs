using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigGuaranteeAu
    {
        public int Id { get; set; }
        public string? ColIdExt { get; set; }
        public string? MainCust { get; set; }
        public string? CollateralType { get; set; }
        public string? CollSubtype { get; set; }
        public string? IsCredproCustomer { get; set; }
        public string? GurantorName { get; set; }
        public string? DoeDob { get; set; }
        public string? Gender { get; set; }
        public string? Pan { get; set; }
        public string? KmpType { get; set; }
        public string? KmpTypeOthers { get; set; }
        public string? ExtensionCreation { get; set; }
        public string? RelationshipWithBorrower { get; set; }
        public string? RelationshipDetails { get; set; }
        public string? Address { get; set; }
        public string? PinCode { get; set; }
        public string? Phone { get; set; }
        public string? Nationality { get; set; }
        public string? AddressCountry { get; set; }
    }
}
