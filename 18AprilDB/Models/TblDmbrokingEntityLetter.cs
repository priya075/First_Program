using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmbrokingEntityLetter
    {
        public int DmBelId { get; set; }
        public int? DmId { get; set; }
        public int? DmDtypid { get; set; }
        public string? BrokingEntity { get; set; }
        public string? BrokingEntityAccountNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
