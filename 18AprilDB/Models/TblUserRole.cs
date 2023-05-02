using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserRole
    {
        public int UrId { get; set; }
        public int? UId { get; set; }
        public int? CId { get; set; }
        public int? MId { get; set; }
        public int? RId { get; set; }
        public int? MWfId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }

        public virtual TblCustomer? CIdNavigation { get; set; }
        public virtual TblModule? MIdNavigation { get; set; }
    }
}
