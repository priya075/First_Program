using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwGetAllDisplaySectionConfig
    {
        public int Id { get; set; }
        public string? MWfId { get; set; }
        public string? WorkflowName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Purpose { get; set; }
    }
}
