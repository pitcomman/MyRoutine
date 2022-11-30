using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzzProcessSuspendedBlocking
    {
        public short Spid { get; set; }
        public string Status { get; set; } = null!;
        public string? Loginame { get; set; }
        public string? Hostname { get; set; }
        public string? Blk { get; set; }
        public string? Dbname { get; set; }
        public string Cmd { get; set; } = null!;
        public byte[] Waittype { get; set; } = null!;
    }
}
