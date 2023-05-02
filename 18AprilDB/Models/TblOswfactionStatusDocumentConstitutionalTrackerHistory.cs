using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusDocumentConstitutionalTrackerHistory
    {
        public int Id { get; set; }
        public int WfstconstId { get; set; }
        public int WfstdocId { get; set; }
        public int? WfaId { get; set; }
        public string? ConstitutionalId { get; set; }
        public int? RId { get; set; }
        public int? MId { get; set; }
        public int? MWfId { get; set; }
        public int? ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? XmlConstitutional { get; set; }
    }
}
