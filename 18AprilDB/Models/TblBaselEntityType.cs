using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBaselEntityType
    {
        public int Bslid { get; set; }
        public string Description { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
