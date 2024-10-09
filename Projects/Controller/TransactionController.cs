using Projects.DTOs;
using Projects.Handler;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace Projects.Controller
{
    public class TransactionController
    {
        public static void AddNewTransaction(int userID, DateTime transactionDate)
        {
            TransactionHandler.AddNewTransaction(userID, transactionDate);
        }

        public static int GetTransactionID()
        {
            int id = TransactionHandler.GetTransactionID();
            return id;
        }

        public static List<object> GetTransactionByEachUser(int id)
        {
            return TransactionHandler.GetTransactionByEachUser(id);
        }

        public static List<TransactionHeaderWithDetails> GetAllTransactions()
        {
            return TransactionHandler.GetAllTransactions();
        }
    }
}