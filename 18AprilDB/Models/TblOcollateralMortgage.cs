using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcollateralMortgage
    {
        public int CmrtId { get; set; }
        public int AcId { get; set; }
        public string Colid { get; set; } = null!;
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public string? AssetDescription { get; set; }
        public string? AssetLocation { get; set; }
        public bool? BorrowerIsOwnerOfAsset { get; set; }
        public int? ChargeLevel { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
