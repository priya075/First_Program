using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAppSectionMaster
    {
        public int Id { get; set; }
        public string? SectionDisplayName { get; set; }
        public string? SectionName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
