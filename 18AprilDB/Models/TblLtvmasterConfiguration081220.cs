using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblLtvmasterConfiguration081220
    {
        public int Id { get; set; }
        public int? DeptId { get; set; }
        public int? ProgId { get; set; }
        public int? BankingType { get; set; }
        public int? FstypId { get; set; }
        public int? CstypId { get; set; }
        public int? OccStatus { get; set; }
        public int? DevelopArea { get; set; }
        public int? Lessee { get; set; }
        public decimal? ApplicableLtv { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
