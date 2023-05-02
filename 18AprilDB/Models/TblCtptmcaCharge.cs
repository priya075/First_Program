using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptmcaCharge
    {
        public int Id { get; set; }
        public string? CtptId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? HolderName { get; set; }
        public string? Type { get; set; }
        public string? Source { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? DateOfModification { get; set; }
        public DateTime? DateOfSatisfaction { get; set; }
        public string? AssetsUnderCharge { get; set; }
        public string? ChargeId { get; set; }
    }
}
