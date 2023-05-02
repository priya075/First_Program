using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTsconditionsMaster20180910
    {
        public int Id { get; set; }
        public int? Fstypid { get; set; }
        public int? MWfId { get; set; }
        public string? XmlCond { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
