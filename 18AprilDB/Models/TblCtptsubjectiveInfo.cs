using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptsubjectiveInfo
    {
        public int Id { get; set; }
        public string? CtptId { get; set; }
        public string? InfoType { get; set; }
        public string? Name { get; set; }
        public decimal? Percentage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Token { get; set; }
    }
}
