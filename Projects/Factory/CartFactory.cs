using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Factory
{
    public class CartFactory
    {
        public static Cart AddNewCart(int userID, int stationeryID, int qty)
        {
            Cart newCart = new Cart();
            newCart.UserID = userID;
            newCart.StationeryID = stationeryID;
            newCart.Quantity = qty;

            return newCart;
        }
    }
}