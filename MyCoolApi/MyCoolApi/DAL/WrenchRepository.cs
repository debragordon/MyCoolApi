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
        public Wrench AddNewWrench(Wrench newWrench)
        {
            throw new NotImplementedException();
        }

        public List<Wrench> GetAllWrenches()
        {
            throw new NotImplementedException();
        }

        public Wrench GetByPartNumber(string partNo)
        {
            throw new NotImplementedException();
        }
    }
}