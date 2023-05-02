using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPincodeMaster
    {
        public int Id { get; set; }
        public string? ZipCode { get; set; }
        public string? CityId { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public string? Regionname { get; set; }
        public string? Divisionname { get; set; }
        public string? CircleName { get; set; }
        public string? Taluka { get; set; }
        public string? Area { get; set; }
        public string? StateId { get; set; }
        public string? StateCode { get; set; }
        public string? StateName { get; set; }
        public string? CountryId { get; set; }
        public string? Countryisdcode { get; set; }
        public string? Countryisocode { get; set; }
        public string? CountryName { get; set; }
        public string? LocationType { get; set; }
        public string? AreaStatus { get; set; }
        public string? WorkingArea { get; set; }
        public string? FiEmpCode { get; set; }
        public string? FiEmpName { get; set; }
        public int? CpStId { get; set; }
        public int? CpCtId { get; set; }
        public string? District { get; set; }
    }
}
