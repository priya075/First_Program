﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPrivateRoomCommentsHistory
    {
        public int Prchid { get; set; }
        public int Id { get; set; }
        public string? RoomName { get; set; }
        public string? AppId { get; set; }
        public int? CtptId { get; set; }
        public string? XmlComments { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
