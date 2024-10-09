using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.DTOs
{
    public class TransactionHeaderWithDetails
    {
        public int TransactionId { get; set; }
        public int UserID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int GrandTotal { get; set; }
        public List<TransactionDetails> TransactionDetails { get; set; }
    }
}