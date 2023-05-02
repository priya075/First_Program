using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptaddress
    {
        public int AdId { get; set; }
        public string? CtptId { get; set; }
        public string? Address1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public bool? IsRegistered { get; set; }
        public string? Source { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? AtId { get; set; }
        public int? IncludeInFl { get; set; }
    }
}
