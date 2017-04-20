using MyCoolApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCoolApi.Models;

namespace MyCoolApi.DAL
{
    public class CleatRepository : ICleatRepository
    {
        //not sure this will work
        public Cleat AddNewCleat(Cleat newCleat)
        {
            if (newCleat == null) return null;
            else
            {
                var addedCleat = new Cleat
                {
                    Name = newCleat.Name,
                    Price = newCleat.Price,
                    PartNumber = newCleat.PartNumber,
                    Color = newCleat.Color,
                    Sport = newCleat.Sport,
                    Brand = newCleat.Brand
                };
                return addedCleat;
            }
        }

        public List<Cleat> GetAllCleats() //don't think this is enough, not sure how to get all cleats
        {
            var allCleats = new List<Cleat>();
            return allCleats;
        }

        //I don't like this ... I want to build the cleat objects somewhere else and then call for them here to make it look cleaner
        public Cleat GetByPartNumber(string partNo)
        {
            if (partNo == "14D0T25X")
            {
                return new Cleat
                {
                    Name = "Stinger",
                    Price = 14.99,
                    PartNumber = "14D0T25X",
                    Color = "Black/Yellow",
                    Sport = "Golf",
                    Brand = "Champ"
                };
            }
            if (partNo == "20D0T25Z")
            {
                return new Cleat
                {
                    Name = "Pulsar",
                    Price = 14.99,
                    PartNumber = "20D0T25Z",
                    Color = "Black/White",
                    Sport = "Golf",
                    Brand = "Softspikes"
                };
            }
            else return null;
        }
    }
}