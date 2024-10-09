using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Repository
{
    public class TransactionDetailRepository
    {
        public static void AddTransactionDetail(TransactionDetail td)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }

        public static List<object> GetTransactionDetailByEachCustomer(int transactionID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var listTransactionDetails = (
                from td in db.TransactionDetails
                join s in db.MsStationeries on td.StationeryID equals s.StationeryID
                where td.TransactionID == transactionID
                select new { s.StationeryName, s.StationeryPrice, td.Quantity }
            ).ToList();

            return listTransactionDetails.Cast<object>().ToList();
        }

        public static List<object> GetAllTransactionDetail(int transactionID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();

            var listTransactions = (
                from td in db.TransactionDetails 
                join s in db.MsStationeries on td.StationeryID equals s.StationeryID
                where td.TransactionID == transactionID
                select new
                {
                    td.TransactionID,
                    s.StationeryName,
                    td.Quantity,
                    s.StationeryPrice,
                    SubTotal = td.Quantity * s.StationeryPrice
                }
            ).ToList();

            return listTransactions.Cast<object>().ToList();
        }
    }
}