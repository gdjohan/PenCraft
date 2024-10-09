using Projects.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Controller
{
    public class TransactionDetailController
    {
        public static void AddNewTransactionDetail(int userID, int TransactionID)
        {
            TransactionDetailHandler.AddNewTransactionDetail(userID, TransactionID);
        }

        public static List<object> GetTransactionDetailByEachCustomer(int transactionID)
        {
            return TransactionDetailHandler.GetTransactionDetailByEachCustomer(transactionID);
        }

        public static List<object> GetAllTransactionDetail(int transactionID)
        {
            return TransactionDetailHandler.GetAllTransactionDetail(transactionID);
        }
    }
}