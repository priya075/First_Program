using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblGstanalysisDetail
    {
        public int Id { get; set; }
        public string? GstNumber { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string? UpdateSource { get; set; }
        public string? Fforder { get; set; }
        public string? LatestFforder { get; set; }
        public string? LenderReferenceNo { get; set; }
        public string? LenderDivision { get; set; }
        public string? LenderBranch { get; set; }
        public string? LegalName { get; set; }
        public string? TaxpayerType { get; set; }
        public string? Constitution { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? Gstin { get; set; }
        public string? State { get; set; }
        public decimal? DomesticSales { get; set; }
        public decimal? OutwardTaxableSupplies { get; set; }
        public decimal? OutwardTaxableSuppliesZeroRated { get; set; }
        public decimal? OtherOutwardSuppliesNilRatedExempted { get; set; }
        public decimal? InwardSuppliesLiableToReverseCharge { get; set; }
        public decimal? NonGstOutwardSupplies { get; set; }
        public decimal? ExportSales { get; set; }
        public decimal? GeneralSuppliesPurchases { get; set; }
        public decimal? ContOfTop5BuyersPerOfTotalSales { get; set; }
        public decimal? ContOfTop5BuyersValue { get; set; }
        public decimal? ContOfTop5VendorsPerOfTotalSales { get; set; }
        public decimal? ContOfTop5VendorsValue { get; set; }
        public decimal? AvgInvoiceValueSalesValueOfInvoice { get; set; }
        public decimal? AvgInvoiceValueSalesNoOfInvoices { get; set; }
        public decimal? AvgOfInvoicesPurchasesValueOfInvoice { get; set; }
        public decimal? AvgOfInvoicesPurchasesNoOfInvoices { get; set; }
        public decimal? GstPaid { get; set; }
        public DateTime? Gstr3bFilingDate { get; set; }
        public decimal? TaxPaid3bReportTotalTaxPayable { get; set; }
        public decimal? TaxPaid3bReportTaxPaidThroughItc { get; set; }
        public decimal? TaxPaid3bReportTaxPaidInCash { get; set; }
        public decimal? TaxPaid3bReportInterestFeePaidInCash { get; set; }
        public decimal? TaxPaid3bReportLateFeePaidInCash { get; set; }
        public DateTime? Gstr1FilingDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public decimal? TaxPaidThroughItcIntegratedTax { get; set; }
        public decimal? TaxPaidThroughItcCentralTax { get; set; }
        public decimal? TaxPaidThroughItcStateTax { get; set; }
        public decimal? TaxPaidThroughItcCess { get; set; }
    }
}
