using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcollateralSubType
    {
        public int Cstypid { get; set; }
        public string? CollateralSubCode { get; set; }
        public string ColSubType { get; set; } = null!;
        public int? ShowPanel { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public decimal RealizableValue { get; set; }
        public int? MstSourceId { get; set; }
        public string? PanelVirtualPath { get; set; }
    }
}
