using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCbeconomicSector
    {
        public int Cbesid { get; set; }
        public string CbeconomicSectorCode { get; set; } = null!;
        public string CbeconomicSectorName { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
        public string? ShortDesc { get; set; }
    }
}
