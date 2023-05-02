using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCustomerRequestsDraft
    {
        public int Id { get; set; }
        public string UniqueId { get; set; } = null!;
        public int UId { get; set; }
        public string RequestDetails { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
