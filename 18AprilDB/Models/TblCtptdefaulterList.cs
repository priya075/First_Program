﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptdefaulterList
    {
        public int Id { get; set; }
        public string? CtptId { get; set; }
        public string? Comment { get; set; }
        public string? List { get; set; }
        public int? Source { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? FetchDate { get; set; }
    }
}
