using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTableObjectXmlschema
    {
        public int Ocxid { get; set; }
        public string ObjectName { get; set; } = null!;
        public string ObjectXml { get; set; } = null!;
        public string XmlFilePath { get; set; } = null!;
        public string? ObjectXmlIn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
