using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDeficiency
    {
        public int Id { get; set; }
        public string DefwrapperId { get; set; } = null!;
        public string XmlDeficiency { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
