using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBsastatementUpload
    {
        public int Id { get; set; }
        public int? FuId { get; set; }
        public int? LatestFuId { get; set; }
        public string? AccountNo { get; set; }
        public string? IfscCode { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string? UpdateSource { get; set; }
        public int? NoOfCreditTransactions { get; set; }
        public decimal? CreditTransactionsAmount { get; set; }
        public int? NoOfDebitTransactions { get; set; }
        public decimal? DebitTransactionsAmount { get; set; }
        public int? NoOfNetCreditTransactions { get; set; }
        public decimal? NetCreditTransactionsAmount { get; set; }
        public int? NoOfNetDebitTransactions { get; set; }
        public decimal? NetDebitTransactionsAmount { get; set; }
        public int? NoOfCashWithdrawals { get; set; }
        public decimal? CashWithdrawalsAmount { get; set; }
        public int? NoOfAtmwithdrawals { get; set; }
        public decimal? AtmWithdrawalsAmount { get; set; }
        public int? NoOfCashDeposits { get; set; }
        public decimal? CashDepositsAmount { get; set; }
        public int? NoOfChequeBounceInward { get; set; }
        public decimal? ChequeBounceInwardAmount { get; set; }
        public int? NoOfChequeBounceOutward { get; set; }
        public decimal? ChequeBounceOutwardAmount { get; set; }
        public int? NoOfPaymentBounceInward { get; set; }
        public decimal? PaymentBounceInwardAmount { get; set; }
        public int? NoOfPaymentBounceOutward { get; set; }
        public decimal? PaymentBounceOutwardAmount { get; set; }
        public int? NoOfChequeDeposits { get; set; }
        public decimal? ChequeDepositsAmount { get; set; }
        public int? NoOfChequeIssued { get; set; }
        public decimal? ChequeIssuedAmount { get; set; }
        public int? NoOfLoanDisbursal { get; set; }
        public decimal? LoanDisbursalAmount { get; set; }
        public decimal? SalaryAmount { get; set; }
        public int? NoOfMinimumBalanceCharges { get; set; }
        public decimal? MinimumEodbalance { get; set; }
        public decimal? MaximumEodbalance { get; set; }
        public decimal? AverageEodbalance { get; set; }
        public decimal? BalanceOn5th { get; set; }
        public decimal? BalanceOn15th { get; set; }
        public decimal? BalanceOn25th { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? AccountType { get; set; }
        public decimal? MonthlySales { get; set; }
        public decimal? ExistingLimit { get; set; }
        public decimal? AvgLimitUtilization { get; set; }
        public int? LimitOverdrawnDays { get; set; }
        public decimal? PeakOverdrawnAmount { get; set; }
        public int? AggDelayInterestPaymentDays { get; set; }
        public int? NoInwardChequeReturn { get; set; }
        public decimal? CreditSummationPer { get; set; }
        public int? OutwardChequeReturnPer { get; set; }
        public decimal? AvgLimitUtilizationPer { get; set; }
        public decimal? InwardChequeReturnPer { get; set; }
    }
}
