using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblLeftMenu
    {
        public int Id { get; set; }
        public string? LinkName { get; set; }
        public string? LinkUrl { get; set; }
        public int? ParentLinkId { get; set; }
        public string? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEditable { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? ExportToExcel { get; set; }
        public string? RelevantTblName { get; set; }
        public string? RelevantClassName { get; set; }
        public bool? IsCacheable { get; set; }
        public string? CacheKey { get; set; }
        public int? SequenceOrder { get; set; }
        public string? XmlDetails { get; set; }
    }
}
