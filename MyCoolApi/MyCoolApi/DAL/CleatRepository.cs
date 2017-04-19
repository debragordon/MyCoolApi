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
        public Cleat AddNewWrench(Cleat newWrench)
        {
            throw new NotImplementedException();
        }

        public List<Cleat> GetAllCleats()
        {
            throw new NotImplementedException();
        }

        public Cleat GetByPartNumber(string partNo)
        {
            throw new NotImplementedException();
        }
    }
}