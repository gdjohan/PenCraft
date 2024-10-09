using Projects.Factory;
using Projects.Model;
using Projects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Handler
{
    public class StationeryHandler
    {
        public static String CreateNewStationery(string name, int price)
        {
            MsStationery newStationery = StationeryFactory.CreateNewStationery(name, price);
            StationeryRepository.AddStationery(newStationery);
            return "Stationery added successfully";
        }

        public static String UpdateStationery(int id, string name, int price)
        {
            StationeryRepository.UpdateStationery(id, name, price);
            return "Stationery updated successfully";
        }

        public static List<MsStationery> GetAllStationeries()
        {
            List<MsStationery> listStationeries = StationeryRepository.GetAllStationeries();
            return listStationeries;
        }

        public static MsStationery GetStationery(int id)
        {
            MsStationery stationery = StationeryRepository.GetStationeryById(id);
            return stationery;
        }

        public static void DeleteStationery(int id)
        {
            StationeryRepository.DeleteStationery(id);
        }
    }
}