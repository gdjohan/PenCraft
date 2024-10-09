using Projects.Factory;
using Projects.Model;
using Projects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Handler
{
    public class TransactionDetailHandler
    {
        public static void AddNewTransactionDetail(int userID, int transactionID)
        {
            List<Cart> listCarts = CartRepository.GetUserCarts(userID);

            foreach(Cart c in listCarts)
            {
                TransactionDetail newTransactionDetail = TransactionDetailFactory.CreateNewTransactionDetail(transactionID, c.StationeryID, c.Quantity);
                TransactionDetailRepository.AddTransactionDetail(newTransactionDetail);
            }
        }

        public static List<object> GetTransactionDetailByEachCustomer(int transactionID)
        {
            return TransactionDetailRepository.GetTransactionDetailByEachCustomer(transactionID);
        }

        public static List<object> GetAllTransactionDetail(int transactionID)
        {
            return TransactionDetailRepository.GetAllTransactionDetail(transactionID);
        }
    }
}