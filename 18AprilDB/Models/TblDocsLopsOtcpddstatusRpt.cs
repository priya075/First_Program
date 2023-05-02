using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDocsLopsOtcpddstatusRpt
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public string? DocId { get; set; }
        public string? DmDtypid { get; set; }
        public string? DocumentTypeDesc { get; set; }
        public string? UniqueId { get; set; }
        public string? ApplicableFor { get; set; }
        public string? DocumentSystemStatus { get; set; }
        public DateTime? DefermentDueDate { get; set; }
        public string? TypeOfDeferral { get; set; }
        public string? Col1 { get; set; }
    }
}
