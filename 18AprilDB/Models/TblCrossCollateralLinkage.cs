using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCrossCollateralLinkage
    {
        public int Id { get; set; }
        public string? ColId { get; set; }
        public string? CrossColId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
