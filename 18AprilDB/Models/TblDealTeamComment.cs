using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDealTeamComment
    {
        public int Dtid { get; set; }
        public string? AppId { get; set; }
        public int? CtptId { get; set; }
        public string? XmlComments { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
