using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateNewTransaction(int userID, DateTime transactionDate)
        {
            TransactionHeader newTransaction = new TransactionHeader();
            newTransaction.UserID = userID;
            newTransaction.TransactionDate = transactionDate;

            return newTransaction;
        }
    }
}