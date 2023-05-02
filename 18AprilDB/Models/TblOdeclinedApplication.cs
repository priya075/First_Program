using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOdeclinedApplication
    {
        public int DeclId { get; set; }
        public string AppDecId { get; set; } = null!;
        public int WfstappId { get; set; }
        public string AppId { get; set; } = null!;
        public int CtptId { get; set; }
        public string Uname { get; set; } = null!;
        public int RId { get; set; }
        public int MWfId { get; set; }
        public int? ParentMWfId { get; set; }
        public DateTime ActionDate { get; set; }
        public string? StatusOnDecline { get; set; }
        public string? SanctionId { get; set; }
        public string? PdffileName { get; set; }
        public string? PdffilePath { get; set; }
        public int? RegnId { get; set; }
        public int? UfId { get; set; }
        public string? ExternalDocRef { get; set; }
    }
}
