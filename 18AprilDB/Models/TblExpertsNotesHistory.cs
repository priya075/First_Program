using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExpertsNotesHistory
    {
        public int Histenid { get; set; }
        public int? Enid { get; set; }
        public int NwfrId { get; set; }
        public string? AppId { get; set; }
        public int? CtptId { get; set; }
        public string? XmlComments { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
