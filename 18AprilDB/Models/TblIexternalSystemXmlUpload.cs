using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblIexternalSystemXmlUpload
    {
        public int XuId { get; set; }
        public string? SystemName { get; set; }
        public string? XmlFileName { get; set; }
        public string? XmlFilePath { get; set; }
        public string? XmlIn { get; set; }
        public string? Status { get; set; }
        public string? Entity { get; set; }
    }
}
