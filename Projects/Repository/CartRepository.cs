using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace Projects.Repository
{
    public class CartRepository
    {
        public static void AddCart(Cart cart)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();

            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public static List<object> GetAllCarts(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var listCarts = (
                from c in db.Carts
                join u in db.MsUsers on c.UserID equals u.UserID
                join s in db.MsStationeries on c.StationeryID equals s.StationeryID
                where c.UserID == id
                select new { s.StationeryName, s.StationeryPrice, c.Quantity }
            ).ToList();

            return listCarts.Cast<object>().ToList();
        }

        public static List<Cart> GetUserCarts(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<Cart> listCarts = (
                from c in db.Carts
                where c.UserID == id
                select c
            ).ToList();

            return listCarts;
        }

        public static void RemoveCart(int userID, int stationeryID, int qty)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            Cart cart = (
                from c in db.Carts
                where c.UserID == userID && c.StationeryID == stationeryID && c.Quantity == qty
                select c
            ).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public static void RemoveAllCart(int userID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var cartsToRemove = (from c in db.Carts where c.UserID == userID select c).ToList();
            db.Carts.RemoveRange(cartsToRemove);
            db.SaveChanges();
        }

        public static void UpdateCart(int userID, int stationeryID, int qty)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            Cart cart = (
                from c in db.Carts
                where c.UserID == userID && c.StationeryID == stationeryID
                select c
            ).FirstOrDefault();
            cart.Quantity = qty;
            db.SaveChanges();
        }

        public static int GetQty(int userID, int stationeryID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            int qty = (
                from c in db.Carts
                where c.UserID == userID && c.StationeryID == stationeryID
                select c.Quantity
            ).FirstOrDefault();
            return qty;
        }
    }
}