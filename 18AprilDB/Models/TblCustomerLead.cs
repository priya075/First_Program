using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCustomerLead
    {
        public int LdId { get; set; }
        public string? LeadId { get; set; }
        public string? CustomerName { get; set; }
        public string? XmlDetails { get; set; }
        public bool IsConsumed { get; set; }
        public string? Status { get; set; }
        public DateTime? DataFeedDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
