using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblInterfaceDetail
    {
        public int Ifid { get; set; }
        public string ObjectName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string? XmlField { get; set; }
        public string IdField { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
