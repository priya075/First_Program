using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblUserPermissions = new HashSet<TblUserPermission>();
            TblUserRoles = new HashSet<TblUserRole>();
        }

        public int CId { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactPersonName { get; set; }
        public string? EmailId { get; set; }
        public string? OfficeAddress1 { get; set; }
        public string? OfficeAddress2 { get; set; }
        public string? Phone1 { get; set; }
        public string? Mobile1 { get; set; }
        public bool? Status1 { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }

        public virtual ICollection<TblUserPermission> TblUserPermissions { get; set; }
        public virtual ICollection<TblUserRole> TblUserRoles { get; set; }
    }
}
