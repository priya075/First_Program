using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFavCounterparty
    {
        public int Id { get; set; }
        public int? UId { get; set; }
        public int? CtptId { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
