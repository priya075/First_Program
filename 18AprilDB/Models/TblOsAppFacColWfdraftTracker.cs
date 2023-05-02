using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsAppFacColWfdraftTracker
    {
        public int OsdrftId { get; set; }
        /// <summary>
        /// FK to  3 tables of tblOSWFActionStatusApplicationTracker, tblOSWFActionStatusFacilityTracker and 
        /// </summary>
        public int WfstId { get; set; }
        /// <summary>
        /// FK to tblCounterparty
        /// </summary>
        public int CtptId { get; set; }
        /// <summary>
        /// FK to tblCounterparty
        /// </summary>
        public string Ctptname { get; set; } = null!;
        public Guid AppGuid { get; set; }
        public string DraftType { get; set; } = null!;
        /// <summary>
        /// Fk to tblUsers
        /// </summary>
        public int Uid { get; set; }
        public int RId { get; set; }
        /// <summary>
        /// FK to UserName in tblUsers
        /// </summary>
        public string UserName { get; set; } = null!;
        public int? DeptId { get; set; }
        public string Draftxml { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int? Aptypid { get; set; }
        public int? MWfId { get; set; }
    }
}
