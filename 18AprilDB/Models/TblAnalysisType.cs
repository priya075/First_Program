using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAnalysisType
    {
        public TblAnalysisType()
        {
            TblAnalysisConfigMasters = new HashSet<TblAnalysisConfigMaster>();
        }

        public int Antypid { get; set; }
        public string? AnalysisType { get; set; }

        public virtual ICollection<TblAnalysisConfigMaster> TblAnalysisConfigMasters { get; set; }
    }
}
