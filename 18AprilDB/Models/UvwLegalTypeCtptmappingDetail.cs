using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwLegalTypeCtptmappingDetail
    {
        public int CpId { get; set; }
        public int? CptId { get; set; }
        public string? CounterpartyType { get; set; }
        public int? LtId { get; set; }
        public string? LegalConstitutionType { get; set; }
    }
}
