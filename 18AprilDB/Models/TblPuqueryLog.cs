using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPuqueryLog
    {
        public int Id { get; set; }
        public string? Query { get; set; }
        public string? UserName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
