using Projects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projects.Factory
{
    public class StationeryFactory
    {
        public static MsStationery CreateNewStationery(string name, int price)
        {
            MsStationery newStationery = new MsStationery();
            newStationery.StationeryName = name;
            newStationery.StationeryPrice = price;

            return newStationery;
        }
    }
}