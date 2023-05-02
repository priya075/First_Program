using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFieldsConfiguration
    {
        public int Id { get; set; }
        public string PageName { get; set; } = null!;
        public string? FieldsConfig { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
