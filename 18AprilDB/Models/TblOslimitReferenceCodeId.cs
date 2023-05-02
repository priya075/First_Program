using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOslimitReferenceCodeId
    {
        public int Lrcid { get; set; }
        public string? LimitReferenceCode { get; set; }
        /// <summary>
        /// When LimitReferenceCodeStatus=&quot;Y&quot; Ready for release (it can be delete)
        /// 
        /// When LimitReferenceCodeStatus=&quot;R&quot;  Release code(after delete)
        /// 
        /// When LimitReferenceCodeStatus=&quot;N&quot;  it can not be reused(When Facility Approved) 
        /// </summary>
        public string? LimitReferenceCodeStatus { get; set; }
    }
}
