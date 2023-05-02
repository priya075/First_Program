using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisreportForCcbg
    {
        public int? Sno { get; set; }
        public string? UniqueId { get; set; }
        public string? AppId { get; set; }
        public string? BorrowerName { get; set; }
        public string? PanNo { get; set; }
        public string? CifId { get; set; }
        public string? Zone { get; set; }
        public string? UnitHead { get; set; }
        public string? ZonalHead { get; set; }
        public string? Rm { get; set; }
        public string? DepartmentType { get; set; }
        public string? BusinessUnit { get; set; }
        public string? PresentRole { get; set; }
        public string? PresentUserName { get; set; }
        public string? CommitteeName { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
