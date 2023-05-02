using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExternalUser
    {
        public int UId { get; set; }
        public string UserId { get; set; } = null!;
        public string? Password { get; set; }
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLoggedIn { get; set; }
        public bool? IsBlocked { get; set; }
        public string? UserToken { get; set; }
        public string? WebOtp { get; set; }
        public string? MobileOtp { get; set; }
        public string? OtherDetails { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
