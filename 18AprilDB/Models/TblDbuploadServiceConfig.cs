using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDbuploadServiceConfig
    {
        public int Id { get; set; }
        public string ServiceKey { get; set; } = null!;
        public string ConnectionType { get; set; } = null!;
        public string? ConnectionString { get; set; }
        public bool? IsDestinationCommand { get; set; }
        public string? CommandType { get; set; }
        public string? Command { get; set; }
        public string? ArchivalStoredProcedure { get; set; }
        public string DestinationTable { get; set; } = null!;
        public string? PostUploadCsfunction { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
