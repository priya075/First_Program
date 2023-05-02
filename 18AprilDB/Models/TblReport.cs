using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblReport
    {
        public int ReId { get; set; }
        public int? MId { get; set; }
        public int? MWfId { get; set; }
        public string ReportName { get; set; } = null!;
        public string? Description { get; set; }
        public string? ReportUploadPath { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ReportAdapter { get; set; }
        public string? DataSetTable { get; set; }
        public string? NavigateUrl { get; set; }
        public string? ReportModel { get; set; }
    }
}
