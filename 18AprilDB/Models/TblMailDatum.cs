using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMailDatum
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public Guid? UserIdU { get; set; }
        public string? UserName { get; set; }
        public string? SendTo { get; set; }
        public string? MailSubject { get; set; }
        public string? MailMessage { get; set; }
        public string? RepliedMessage { get; set; }
        public string? SendType { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? ReplyDate { get; set; }
        public bool? MailStatus { get; set; }
    }
}
