using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCountry
    {
        public int CtId { get; set; }
        public string? Code { get; set; }
        public string? Country { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? MstSourceId { get; set; }
    }
}
