using MyCoolApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApi.Interfaces
{
    public interface ICleatRepository
    {
        Cleat GetByPartNumber(string partNo);
        List<Cleat> GetAllCleats();
        Cleat AddNewCleat(Cleat newCleat);
    }
}
