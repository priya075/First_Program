using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptpassport
    {
        public int CtPpId { get; set; }
        public string? CtptId { get; set; }
        public string? NameOnPassport { get; set; }
        public string? PassportNumber { get; set; }
        public string? PassportExpiryDate { get; set; }
    }
}
