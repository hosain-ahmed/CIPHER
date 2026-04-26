using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
    public class LogEntry
    {
        public string Category { get; set; } // SYS, ECO, or SEC
        public string Action { get; set; }   // EventType or Type
        public string Details { get; set; }  // Details or Description
        public DateTime Timestamp { get; set; }
    }
}
