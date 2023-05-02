using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCity
    {
        public int CyId { get; set; }
        public string? CityName { get; set; }
        public int? StId { get; set; }
        public int? CtId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
