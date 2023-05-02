using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAnalysisConfigMaster
    {
        public int Anlcid { get; set; }
        public int Antypid { get; set; }
        public string? Level1Tabtypeid { get; set; }
        public string? Tabname { get; set; }
        public int? Sortordertypid { get; set; }
        public string? Level2Tabsubtypid { get; set; }
        public string? Tabsubtyp { get; set; }
        public int? Sortordersubtypid { get; set; }
        public string? Mappedfields { get; set; }
        public bool? Active { get; set; }
        public int? MWfId { get; set; }
        public int? AnalysisStructure { get; set; }
        public int? AnalysisNature { get; set; }

        public virtual TblAnalysisType Antyp { get; set; } = null!;
    }
}
