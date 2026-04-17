using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Models
{
   public class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }

        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
