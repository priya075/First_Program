using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblLegalType
    {
        public int LtId { get; set; }
        public string? LegalConstitutionType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
