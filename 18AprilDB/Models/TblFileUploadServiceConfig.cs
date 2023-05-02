using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFileUploadServiceConfig
    {
        public int Id { get; set; }
        public string ServiceKey { get; set; } = null!;
        public bool IsZipFile { get; set; }
        public string? ZipFileName { get; set; }
        public string? UploadFileName { get; set; }
        public string FilePath { get; set; } = null!;
        public string WorkingFolderPath { get; set; } = null!;
        public string ProcessedPath { get; set; } = null!;
        public string FailedPath { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string? FileDelimiter { get; set; }
        public string? ArchivalStoredProcedure { get; set; }
        public string DestinationTable { get; set; } = null!;
        public string? PostUploadCsfunction { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
