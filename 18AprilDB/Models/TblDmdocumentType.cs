using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmdocumentType
    {
        public int DmDtypid { get; set; }
        public string? DocumentTypeDesc { get; set; }
        public string? EntityName { get; set; }
        public bool? ReleaseAllowed { get; set; }
        public bool? WaiverReleaseAllowed { get; set; }
        public string? DocumentPdfurl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsTimeDriven { get; set; }
        public bool? DtIsActive { get; set; }
        public string? PanelClass { get; set; }
        public string? ApplicableFor { get; set; }
    }
}
