using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFacilityAccountMapping
    {
        public int Id { get; set; }
        public int? MasterObjectId { get; set; }
        public int CtptId { get; set; }
        public string FacId { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string? OtherDetails { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
