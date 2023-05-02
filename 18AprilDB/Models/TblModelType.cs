using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblModelType
    {
        public int MtId { get; set; }
        public string? ModelType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
        public bool? IsInternal { get; set; }
    }
}
