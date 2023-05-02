using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwSummaryOfAllNonAedborrowing
    {
        public string FacId { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public string Uname { get; set; } = null!;
        public int? ClassificationId { get; set; }
        public int? UtilizationAmount { get; set; }
        public string? LimitType { get; set; }
        public int? LimitTypeId { get; set; }
        public int? Tenor { get; set; }
        public DateTime? LimitExpiryDate { get; set; }
        public int? DepartmentId { get; set; }
        public string? Department { get; set; }
        public string? Rmname { get; set; }
        public string? Rmcode { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Cif { get; set; }
        public long? Order { get; set; }
    }
}
