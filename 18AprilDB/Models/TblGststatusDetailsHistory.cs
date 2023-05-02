using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGststatusDetailsHistory
    {
        public int Hid { get; set; }
        public int? Id { get; set; }
        public string? GstNumber { get; set; }
        public string? OrderId { get; set; }
        public string? EmailId1 { get; set; }
        public string? EmailId2 { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? OrderRequestStatus { get; set; }
        public string? OrderResponseStatus { get; set; }
        public string? AnalysisDataIncomingStatus { get; set; }
        public string? AnalysisData { get; set; }
        public string? AnalysisDataOutgoingStatus { get; set; }
        public string? FilesIncomingStatus { get; set; }
        public string? FilesData { get; set; }
        public string? FilesOutgoingStatus { get; set; }
        public DateTime? OrderSendOn { get; set; }
        public DateTime? OrderReceivedOn { get; set; }
        public DateTime? OrderClosedOn { get; set; }
        public DateTime? AnalysisDataReceivedOn { get; set; }
        public DateTime? AnalysisDataProcessedOn { get; set; }
        public DateTime? FileReceivedOn { get; set; }
        public DateTime? FileProcessedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
