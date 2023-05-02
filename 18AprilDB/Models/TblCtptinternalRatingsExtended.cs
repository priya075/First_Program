using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptinternalRatingsExtended
    {
        public int Id { get; set; }
        public string? CtptId { get; set; }
        public string? Token { get; set; }
        public string? AuditMethod { get; set; }
        public string? NoOfGradesAfterOverride { get; set; }
        public string? NameOfSupportingEntity { get; set; }
        public string? IntRatingOfSupportingEntity { get; set; }
        public string? AssessmentType { get; set; }
        public string? IndustryName { get; set; }
        public string? ModelName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
