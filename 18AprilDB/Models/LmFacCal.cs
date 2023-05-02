using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class LmFacCal
    {
        public string? FacId { get; set; }
        public string? ParentFacId { get; set; }
        public string? RootFacId { get; set; }
        public decimal? RealLimit { get; set; }
        public string? RealLimitCcy { get; set; }
        public string? IsRevolving { get; set; }
        public string? IsOneOff { get; set; }
        public int? FacLevel { get; set; }
        public string? FacPath { get; set; }
        public int? CtptId { get; set; }
        public string? FacClass { get; set; }
        public decimal? ProposedLimit { get; set; }
        public string? ProposedLimitCcy { get; set; }
        public decimal? ProposedLimitPrev { get; set; }
        public string? ProposedLimitCcyPrev { get; set; }
        public int? FacType { get; set; }
        public int? FacSubtype { get; set; }
        public int? AnchorCtptId { get; set; }
        public string? AnchorLineFacid { get; set; }
        public bool? AnchorLineWithRecourse { get; set; }
        public int? LineAnchorType { get; set; }
        public string? ChildWithFullRecourseToAnchor { get; set; }
        public decimal? IpaProposedLimit { get; set; }
        public string? IpaProposedLimitCcy { get; set; }
        public decimal? IpaApprovedLimit { get; set; }
        public string? IpaApprovedLimitCcy { get; set; }
        public int? Prrapplicable { get; set; }
        public int? ToBeExcludeFromExpCalc { get; set; }
        public int? CollBackNature { get; set; }
        public int? PropertyPurchaseTl { get; set; }
    }
}
