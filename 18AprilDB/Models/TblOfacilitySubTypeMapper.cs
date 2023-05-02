using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilitySubTypeMapper
    {
        public int Fstmid { get; set; }
        public int? Fstypid { get; set; }
        public int? Mapid { get; set; }
        public string? MapperSource { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
