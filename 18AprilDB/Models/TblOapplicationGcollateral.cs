using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationGcollateral
    {
        public int AcId { get; set; }
        public string? Colid { get; set; }
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public bool? IsSpecificFlag { get; set; }
        public string? Facid { get; set; }
        public string? InitialSnid { get; set; }
        public string? CurrentSnid { get; set; }
        public string? InApplicationCollateralStatus { get; set; }
        public int Colmapid { get; set; }
        public decimal? CollateralValue { get; set; }
        /// <summary>
        /// FK to tblCurrency
        /// </summary>
        public int CollateralValueCurrency { get; set; }
        public DateTime? CollateralValuationDate { get; set; }
        public string? CollateralValuer { get; set; }
        public string? Description { get; set; }
        public string? CollateralId { get; set; }
        public int? MWfId { get; set; }
        public string? XmlCollateralFinal { get; set; }
        public string? CollateralRight { get; set; }
        public string? CollateralReferenceId { get; set; }
        public int? NewCollateralSerial { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
