using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class Tblapplicationconfiguration20230127
    {
        public int Sno { get; set; }
        public string CKey { get; set; } = null!;
        public string? CValue { get; set; }
        public string? CDescription { get; set; }
        public string Status { get; set; } = null!;
        public bool IsActive { get; set; }
        public string ConfigType { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? XmlSchema { get; set; }
        public string? MoreDetails { get; set; }
    }
}
