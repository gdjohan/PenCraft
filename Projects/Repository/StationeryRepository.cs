using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Repository
{
    public class StationeryRepository
    {
        public static void AddStationery(MsStationery stationery)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
        }
        public static List<MsStationery> GetAllStationeries()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<MsStationery> listStationeries = db.MsStationeries.ToList();
            return listStationeries;
        }

        public static MsStationery GetStationeryById(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsStationery stationery = db.MsStationeries.Find(id);
            return stationery;
        }

        public static MsStationery GetStationeryByAttribute(string name, int price)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsStationery stationery = (from s in db.MsStationeries where s.StationeryName == name && s.StationeryPrice == price select s).FirstOrDefault();
            return stationery;
        }

        public static void DeleteStationery(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsStationery stationery = db.MsStationeries.Find(id);
            db.MsStationeries.Remove(stationery);
            db.SaveChanges();
        }

        public static void UpdateStationery(int id, string name, int price)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsStationery newStationery = db.MsStationeries.Find(id);
            newStationery.StationeryName = name;
            newStationery.StationeryPrice = price;
            db.SaveChanges();
        }
    }
}