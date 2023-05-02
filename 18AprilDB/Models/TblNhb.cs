using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblNhb
    {
        public string? SNo { get; set; }
        public string? NameOfTheCustomer { get; set; }
        public string? AddressOfTheCustomerAndLocation { get; set; }
        public string? City { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
