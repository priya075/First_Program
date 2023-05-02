using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationType
    {
        public int Aptypid { get; set; }
        public string ApplicationType { get; set; } = null!;
        public string? ApplicationPageName { get; set; }
    }
}
