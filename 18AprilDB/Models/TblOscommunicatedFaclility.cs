using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOscommunicatedFaclility
    {
        public int ComfacId { get; set; }
        public int Amid { get; set; }
        public int? CtptId { get; set; }
        public int Afid { get; set; }
        public string? Facid { get; set; }
        public string? FacType { get; set; }
        public decimal CommunicatedAmount { get; set; }
        public string? ProposedLimitCurrencyName { get; set; }
        public decimal Margin { get; set; }
        public decimal MinimumRate { get; set; }
        public decimal Tenor { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
