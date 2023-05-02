using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblState
    {
        public int StId { get; set; }
        public string? StateName { get; set; }
        public int? CtId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
        public string? Code { get; set; }
    }
}
