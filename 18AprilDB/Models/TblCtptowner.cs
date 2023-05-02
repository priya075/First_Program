using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptowner
    {
        public int CtOwId { get; set; }
        public string? CtptId { get; set; }
        public bool? OwnershipFlag { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnershipPercent { get; set; }
        public string? PledgeShare { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? OwnershipRegion { get; set; }
        public string? OwnershipBranch { get; set; }
        public string? Nationality { get; set; }
        public string? Category { get; set; }
        public string? Pan { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? PinCode { get; set; }
        public string? Gender { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? ResponseObject { get; set; }
        public string? Cibilscore { get; set; }
        public string? City { get; set; }
        public int? Caste { get; set; }
        public int? Minority { get; set; }
        public string? Cbsnumber { get; set; }
    }
}
