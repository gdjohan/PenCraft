using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.DTOs
{
    public class TransactionDetails
    {
        public int TransactionID { get; set; }
        public string StationeryName { get; set; }
        public int Quantity { get; set; }
        public int StationeryPrice { get; set; }
        public int SubTotal { get; set; }
    }
}