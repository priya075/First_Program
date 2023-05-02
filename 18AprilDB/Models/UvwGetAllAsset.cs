using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllAsset
    {
        public int AstypId { get; set; }
        public string? TypeName { get; set; }
        public int? CptId { get; set; }
        public int? LtId { get; set; }
        public string? AssetTypeClassification { get; set; }
        public string? LegalConstitutionType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? CounterPartyName { get; set; }
    }
}
