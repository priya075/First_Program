using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPrivateRoomsHistory
    {
        public int Prhid { get; set; }
        public int Id { get; set; }
        public string? RoomName { get; set; }
        public string? Description { get; set; }
        public string? AppId { get; set; }
        public int? CtptId { get; set; }
        public int? UId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
