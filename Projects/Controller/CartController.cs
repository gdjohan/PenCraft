using Projects.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Controller
{
    public class CartController
    {
        public static String AddNewCart(int userID, int stationeryID, string qty)
        {
            if (string.IsNullOrEmpty(qty))
            {
                return "All fields must be filled";
            }
            else if (!int.TryParse(qty, out int quantity))
            {
                return "Quantity must be a number";
            }
            else if (Convert.ToInt32(qty) <= 0)
            {
                return "Quantity must be more than 0";
            }
            return CartHandler.AddNewCart(userID, stationeryID, Convert.ToInt32(qty));
        }

        public static List<object> GetAllCarts(int id)
        {
            return CartHandler.GetAllCarts(id);
        }

        public static void RemoveCart(int userID, string name, int price, int qty)
        {
            CartHandler.RemoveCart(userID, name, price, qty);
        }

        public static void RemoveAllCart(int userID)
        {
            CartHandler.RemoveAllCart(userID);
        }
        public static String UpdateCart(int userID, int stationeryID, string qty)
        {
            if (string.IsNullOrEmpty(qty))
            {
                return "All fields must be filled";
            }
            else if (!int.TryParse(qty, out int quantity))
            {
                return "Quantity must be a number";
            }
            else if (Convert.ToInt32(qty) <= 0)
            {
                return "Quantity must be more than 0";
            }
            return CartHandler.UpdateCart(userID, stationeryID, Convert.ToInt32(qty));
        }

        public static int GetCartStationeryID(string name, int price)
        {
            int id = CartHandler.GetCartStationeryID(name, price);
            return id;
        }

        public static int GetQty(int userID, int stationeryID)
        {
            return CartHandler.GetQty(userID, stationeryID);
        }
    }
}