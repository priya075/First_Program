using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblNpasearch
    {
        public string? Type { get; set; }
        public string? AccountNo { get; set; }
        public string? NameOfBorrower { get; set; }
        public string? DateOfNpaDateOfWoff { get; set; }
        public string? Irac { get; set; }
        public string? GnpaAmtOfWoof { get; set; }
        public decimal? Provision { get; set; }
        public string? Status { get; set; }
        public string? ContractNo { get; set; }
        public DateTime? DateOfUpload { get; set; }
        public string? Address { get; set; }
        public string? UploadedBy { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
