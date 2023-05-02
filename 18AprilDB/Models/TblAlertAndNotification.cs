using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAlertAndNotification
    {
        public int Id { get; set; }
        public string? AlertText { get; set; }
        public bool? AlertStatus { get; set; }
        public int? RoleId { get; set; }
        public int? ModuleId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
