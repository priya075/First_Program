using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCounterpartyEwsstatus
    {
        public int Id { get; set; }
        public int CtptId { get; set; }
        public string? XmlEws { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
