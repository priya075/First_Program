using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptcontactDetail
    {
        public int Id { get; set; }
        public string CtptId { get; set; } = null!;
        public string? ContactPerson { get; set; }
        public bool? DirectContact { get; set; }
        public string? EmailId { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Designation { get; set; }
    }
}
