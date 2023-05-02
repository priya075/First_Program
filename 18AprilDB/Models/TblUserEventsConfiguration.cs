using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserEventsConfiguration
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
