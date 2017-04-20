using MyCoolApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCoolApi.Models;

namespace MyCoolApi.DAL
{
    public class WrenchRepository : IWrenchRepository
    {
        //not sure if this works or not
        public Wrench AddNewWrench(Wrench newWrench)
        {
            if (newWrench == null) return null;
            else
            {
                var addedWrench = new Wrench
                {
                    Name = newWrench.Name,
                    Price = newWrench.Price,
                    PartNumber = newWrench.PartNumber,
                    Sport = newWrench.Sport,
                    Brand = newWrench.Brand
                };
                return addedWrench;
            }
        }

        public List<Wrench> GetAllWrenches()
        {
            var allWrenches = new List<Wrench>(); //don't think this is enough - don't think it will work
            return allWrenches;
        }

        //this is hard coded and specific ... are we supposed to connect to a database and let the person select a random part?
        public Wrench GetByPartNumber(string partNo)
        {
            if (partNo == "500WRX")
            {
                return new Wrench
                {
                    Name = "ProWrench",
                    Price = 4.99,
                    PartNumber = "500WRX",
                    Sport = "Golf",
                    Brand = "Champ"
                };
            }
            if (partNo == "600WRX")
            {
                return new Wrench
                {
                    Name = "MaxPro Wrench",
                    Price = 5.99,
                    PartNumber = "500WRX",
                    Sport = "Golf",
                    Brand = "Softspikes"
                };
            }
            else return null;
        }
    }
}