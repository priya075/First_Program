using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTreasurytblUtilizationsCustomer
    {
        public int Cuid { get; set; }
        public int? CtptId { get; set; }
        public int? LimitId { get; set; }
        public string? FacilityId { get; set; }
        public decimal? MtmamountBaseCcy { get; set; }
        public decimal? NotionalAmountBaseCcy { get; set; }
        public decimal? AddonAmountBaseCcy { get; set; }
        public decimal? PfeBaseCcy { get; set; }
        public int? BaseCcy { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
