﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigCrossColl
    {
        public string? CrossColl { get; set; }
        public string? MotherId { get; set; }
        public string? CredProMotherCol { get; set; }
        public string? CredProCrossCol { get; set; }
        public int? CredProCtptId { get; set; }
        public int? CrossCollateralAcId { get; set; }
        public string? CrossCollateralValue { get; set; }
    }
}
