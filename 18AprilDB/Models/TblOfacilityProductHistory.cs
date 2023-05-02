using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilityProductHistory
    {
        public int Fstprodid { get; set; }
        public string FacProduct { get; set; } = null!;
        public int? FstprodT24pid { get; set; }
        public int? FstprodFclsid { get; set; }
        public int? PanelId { get; set; }
        public int? FacStage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
