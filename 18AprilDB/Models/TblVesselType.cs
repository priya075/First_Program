using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblVesselType
    {
        public int Id { get; set; }
        public string? VesselId { get; set; }
        public string? VesselTypeCode { get; set; }
        public string? VesselType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
