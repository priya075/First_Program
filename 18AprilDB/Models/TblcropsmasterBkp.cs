using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblcropsmasterBkp
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public int CpStId { get; set; }
        public string PinDistrict { get; set; } = null!;
        public int Crop { get; set; }
        public decimal CoCperAcre { get; set; }
        public decimal YieldPerAcre { get; set; }
        public decimal MarketPricePerQuintal { get; set; }
        public int Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
