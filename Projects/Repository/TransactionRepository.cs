using Projects.DTOs;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace Projects.Repository
{
    public class TransactionRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static void AddTransaction(TransactionHeader th)
        {
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }

        public static int GetTransactionID()
        {
            int id = db.TransactionHeaders
                .OrderByDescending(t => t.TransactionId)
                .Select(t => t.TransactionId)
                .FirstOrDefault();

            return id;
        }

        public static List<object> GetTransactionByEachUser(int id)
        {
            var listTransactions = (
                from th in db.TransactionHeaders
                join u in db.MsUsers on th.UserID equals u.UserID
                where th.UserID == id
                select new 
                { 
                    th.TransactionId, 
                    th.TransactionDate, 
                    u.UserName 
                }
            ).ToList();

            return listTransactions.Cast<object>().ToList();
        }

        // Buat Crystal Report
        public static List<TransactionHeaderWithDetails> GetAllTransactions()
        {
            var listTransactions = (
                from th in db.TransactionHeaders
                select new TransactionHeaderWithDetails
                {
                    TransactionId = th.TransactionId,
                    UserID = th.UserID,
                    TransactionDate = th.TransactionDate,
                    GrandTotal = (
                        from td in db.TransactionDetails
                        join s in db.MsStationeries on td.StationeryID equals s.StationeryID
                        where td.TransactionID == th.TransactionId
                        select td.Quantity * s.StationeryPrice
                    ).Sum(),
                    TransactionDetails = (
                        from td in db.TransactionDetails
                        join s in db.MsStationeries on td.StationeryID equals s.StationeryID
                        where td.TransactionID == th.TransactionId
                        select new TransactionDetails
                        {
                            TransactionID = td.TransactionID,
                            StationeryName = s.StationeryName,
                            Quantity = td.Quantity,
                            StationeryPrice = s.StationeryPrice,
                            SubTotal = td.Quantity * s.StationeryPrice
                        }
                    ).ToList()
                }
            ).ToList();

            return listTransactions;
        }

    }
}