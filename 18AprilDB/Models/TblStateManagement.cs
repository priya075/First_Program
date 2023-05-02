using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblStateManagement
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? AppId { get; set; }
        public bool? Login { get; set; }
    }
}
