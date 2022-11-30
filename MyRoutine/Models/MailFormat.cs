using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MailFormat
    {
        public string MailFormatCode { get; set; } = null!;
        public int MailFormatSeq { get; set; }
        public string MailTitle { get; set; } = null!;
        public string MailBody { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
