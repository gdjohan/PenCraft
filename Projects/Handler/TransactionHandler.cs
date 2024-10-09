using Projects.DTOs;
using Projects.Factory;
using Projects.Model;
using Projects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Projects.Repository.TransactionRepository;

namespace Projects.Handler
{
    public class TransactionHandler
    {
        public static void AddNewTransaction(int userID, DateTime transactionDate)
        {
            TransactionHeader newTransaction = TransactionFactory.CreateNewTransaction(userID, transactionDate);
            TransactionRepository.AddTransaction(newTransaction);
        }

        public static int GetTransactionID()
        {
            int id = TransactionRepository.GetTransactionID();
            return id;
        }

        public static List<object> GetTransactionByEachUser(int id)
        {
            return TransactionRepository.GetTransactionByEachUser(id);
        }

        public static List<TransactionHeaderWithDetails> GetAllTransactions()
        {
            return TransactionRepository.GetAllTransactions();
        }
    }
}