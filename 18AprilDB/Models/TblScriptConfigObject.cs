using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblScriptConfigObject
    {
        public int Id { get; set; }
        public string ObjectName { get; set; } = null!;
        public string ObjTypeAssembly { get; set; } = null!;
        public string ObjTypeFullPath { get; set; } = null!;
        public string ObjScriptPath { get; set; } = null!;
        public string ObjScriptKey { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
