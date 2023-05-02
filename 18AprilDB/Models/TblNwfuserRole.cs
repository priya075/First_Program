using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblNwfuserRole
    {
        public int NwfurId { get; set; }
        public int NwfrId { get; set; }
        public int UId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
