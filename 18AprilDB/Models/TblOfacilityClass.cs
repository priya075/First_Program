using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilityClass
    {
        public int Fcsid { get; set; }
        public string? Class { get; set; }
        public string? ClassDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
