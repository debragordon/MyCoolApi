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
        public Cleat AddNewCleat(Cleat newCleat)
        {
            throw new NotImplementedException(); //implement this method
        }

        public List<Cleat> GetAllCleats()
        {
            throw new NotImplementedException(); //implement this method
        }

        public Cleat GetByPartNumber(string partNo)
        {
            throw new NotImplementedException(); //implement this method
        }
    }
}