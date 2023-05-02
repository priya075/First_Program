using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmmortgageDeedMaster
    {
        public int DmMrtdId { get; set; }
        public int? DmId { get; set; }
        public int? DmDtypid { get; set; }
        public bool? IsOwner { get; set; }
        public DateTime? ValuationDate { get; set; }
        public string? Valuer { get; set; }
        public DateTime? DateOfMortgage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
