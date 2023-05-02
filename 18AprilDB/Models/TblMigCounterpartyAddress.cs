using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMigCounterpartyAddress
    {
        public string? PrimaryAliasId { get; set; }
        public string? UcicId { get; set; }
        public string? CommAddress { get; set; }
        public string? CommCity { get; set; }
        public string? CommState { get; set; }
        public string? CommPincode { get; set; }
        public string? CommCountry { get; set; }
        public string? IncludeinslcamComm { get; set; }
        public string? CommunicationAddress { get; set; }
        public string? RegAddress { get; set; }
        public string? RegCity { get; set; }
        public string? RegState { get; set; }
        public string? RegPincode { get; set; }
        public string? RegCountry { get; set; }
        public string? IncludeinslcamReg { get; set; }
        public string? RegisteredAddress { get; set; }
    }
}
