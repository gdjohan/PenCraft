using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateNewTransactionDetail(int transactionID, int stationeryID, int qty)
        {
            TransactionDetail newTransactionDetail = new TransactionDetail();
            newTransactionDetail.TransactionID = transactionID;
            newTransactionDetail.StationeryID = stationeryID;
            newTransactionDetail.Quantity = qty;

            return newTransactionDetail;
        }
    }
}