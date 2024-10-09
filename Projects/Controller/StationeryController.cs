using Projects.Handler;
using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Projects.Controller
{
    public class StationeryController
    {
        public static String CreateNewStationery(string name, string price)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                return "All fields must be filled";
            }
            else if (name.Length < 3 || name.Length > 50)
            {
                return "Name must be between 3 - 50 characters";
            }
            else if (!IsNumeric(price))
            {
                return "Price must be numeric";
            }
            else if (Convert.ToInt32(price) < 2000)
            {
                return "Price must be greater or equal to 2000";
            }
            return StationeryHandler.CreateNewStationery(name, Convert.ToInt32(price));
        }

        public static String UpdateStationery(int id, string name, string price)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                return "All fields must be filled";
            }
            else if (name.Length < 3 || name.Length > 50)
            {
                return "Name must be between 3 - 50 characters";
            }
            else if (!IsNumeric(price))
            {
                return "Price must be numeric";
            }
            else if (Convert.ToInt32(price) < 2000)
            {
                return "Price must be greater or equal to 2000";
            }
            return StationeryHandler.UpdateStationery(id, name, Convert.ToInt32(price));
        }

        public static bool IsNumeric(string price)
        {
            Regex numberRegex = new Regex("[0-9]");
            return numberRegex.IsMatch(price);
        }

        public static List<MsStationery> GetAllStationeries()
        {
            List<MsStationery> listStationeries = StationeryHandler.GetAllStationeries();
            return listStationeries;
        }

        public static MsStationery GetStationery(int id)
        {
            MsStationery stationery = StationeryHandler.GetStationery(id);
            return stationery;
        }

        public static void DeleteStationery(int id)
        {
            StationeryHandler.DeleteStationery(id);
        }
    }
}