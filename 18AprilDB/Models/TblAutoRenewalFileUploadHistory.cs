using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAutoRenewalFileUploadHistory
    {
        public int Hid { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustId { get; set; } = null!;
        public string AccountNo { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? OdCcSanctionLimit { get; set; }
        public string? DrawingPower { get; set; }
        public string? Pos { get; set; }
        public DateTime? LimitEndDate { get; set; }
        public DateTime? LimitStartDate { get; set; }
        public string? BranchName { get; set; }
        public string? Region { get; set; }
        public string? Module { get; set; }
        public string? Odcc { get; set; }
        public string? OtherOd { get; set; }
        public string? DlodDp { get; set; }
        public string? TlPos { get; set; }
        public string? LcBg { get; set; }
        public string? TotalExposure { get; set; }
        public string? ChurningPer { get; set; }
        public string? MaxIntServicingDelay { get; set; }
        public string? AverageIntServicingDelay { get; set; }
        public string? UtilizationOfLimit { get; set; }
        public string? NoOfIwChequeReturn { get; set; }
        public string? CreditSummationsBothOdccCa { get; set; }
        public string? MaxDelayInEmiServicingOfTl { get; set; }
        public string? AvgEmiServicingOfTl { get; set; }
        public string? OverdrawnDays { get; set; }
        public string? Cluster { get; set; }
        public string? NoDevolvementInvocationStatus { get; set; }
        public string? ProgramName { get; set; }
        public string? RiskHighlighted { get; set; }
        public string? BorrowerExposureUpto { get; set; }
        public string? GroupExposureUpto { get; set; }
        public string? IrregularTodAdhoc { get; set; }
        public int WfstarId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
