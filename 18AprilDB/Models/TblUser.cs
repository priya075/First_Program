using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUser
    {
        public int UId { get; set; }
        public Guid? ActivityId { get; set; }
        public int? CId { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public string? EmailId { get; set; }
        public string? CommunicationAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? Phone1 { get; set; }
        public string? Mobile1 { get; set; }
        public int? BrId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DgId { get; set; }
        public string? EmployeeId { get; set; }
        public bool? ConfidentialIndicator { get; set; }
        public bool? Status1 { get; set; }
        public int? SanctionAuthorityId { get; set; }
        public bool? IsLoggedIn { get; set; }
        public int? PasswordFailureCount { get; set; }
        public bool? IsBlocked { get; set; }
        public string? T24daocode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? UserSessionId { get; set; }
        public int? CalId { get; set; }
        public bool? IsMancomMember { get; set; }
        public string? RegionId { get; set; }
        public string? Otpsent { get; set; }
        public bool? MloginEnabled { get; set; }
        public int? LandingPage { get; set; }
        public int? OpsLocation { get; set; }
        public string? OpsLocationMultiple { get; set; }
    }
}
