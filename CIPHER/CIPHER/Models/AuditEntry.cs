using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
  public class AuditEntry
    {
        public int LogID { get; set; }
        public int UserID { get; set; }
        public string EventType { get; set; }
        public string Details { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
