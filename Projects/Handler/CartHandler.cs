using Projects.Factory;
using Projects.Model;
using Projects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Handler
{
    public class CartHandler
    {
        public static String AddNewCart(int userID, int stationeryID, int qty)
        {
            Cart newCart = CartFactory.AddNewCart(userID, stationeryID, qty);
            CartRepository.AddCart(newCart);
            return "Cart has been added";
        }

        public static List<object> GetAllCarts(int id)
        {
            return CartRepository.GetAllCarts(id);
        }

        public static void RemoveCart(int userID, string name, int price, int qty)
        {
            MsStationery stationery = StationeryRepository.GetStationeryByAttribute(name, price);
            int stationeryID = stationery.StationeryID;
            CartRepository.RemoveCart(userID, stationeryID, qty);
        }

        public static void RemoveAllCart(int userID)
        {
            CartRepository.RemoveAllCart(userID);
        }

        public static String UpdateCart(int userID, int stationeryID, int qty)
        {
            CartRepository.UpdateCart(userID, stationeryID, qty);
            return "Cart has been updated";
        }

        public static int GetCartStationeryID(string name, int price)
        {
            MsStationery stationery = StationeryRepository.GetStationeryByAttribute(name, price);
            int stationeryID = stationery.StationeryID;
            return stationeryID;
        }

        public static int GetQty(int userID, int stationeryID)
        {
            return CartRepository.GetQty(userID, stationeryID);
        }
    }
}