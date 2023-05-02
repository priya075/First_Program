using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOproductAssetMapping
    {
        public int Paid { get; set; }
        public string? ProductName { get; set; }
        public int? Asid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
