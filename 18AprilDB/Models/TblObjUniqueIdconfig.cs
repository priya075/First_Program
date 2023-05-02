using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblObjUniqueIdconfig
    {
        public int Id { get; set; }
        public string? ObjName { get; set; }
        public string? Prefix { get; set; }
        public string? ObjTable { get; set; }
        public string? ObjDesc { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
