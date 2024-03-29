﻿using System;
using System.Collections.Generic;

namespace NileCapitalCruises.Core.Models
{
    public partial class AspstateTempSession
    {
        public string SessionId { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public DateTime LockDate { get; set; }
        public DateTime LockDateLocal { get; set; }
        public int LockCookie { get; set; }
        public int Timeout { get; set; }
        public bool Locked { get; set; }
        public byte[]? SessionItemShort { get; set; }
        public byte[]? SessionItemLong { get; set; }
        public int Flags { get; set; }
    }
}
