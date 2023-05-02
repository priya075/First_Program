using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblIinterfaceXmlMapping
    {
        public int XmId { get; set; }
        public int? XuId { get; set; }
        public string? ExternalSystemXmlNode { get; set; }
        public string? InternalSystemXmlNode { get; set; }
        public bool? MandatoryExternalXmlNode { get; set; }
        public bool? NonMandatoryExternalXmlNode { get; set; }
        public string? Entity { get; set; }
        public string? ObjectFieldName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
