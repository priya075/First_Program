using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCreditEnhancer
    {
        public string? Token { get; set; }
        public string? BorrId { get; set; }
        public decimal? ModelId { get; set; }
        public decimal? BorrRatingYear { get; set; }
        public string? GuarantorId { get; set; }
        public string? GuarantorName { get; set; }
        public decimal? GuarMdlid { get; set; }
        public decimal? GuarRatingYear { get; set; }
        public string? MstGuarIntRating { get; set; }
        public decimal? GuarMstBusSegmentId { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
    }
}
