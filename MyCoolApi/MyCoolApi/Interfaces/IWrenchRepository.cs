using MyCoolApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApi.Interfaces
{
    public interface IWrenchRepository
    {
        Wrench GetByPartNumber(string partNo);

        List<Wrench> GetAllWrenches();

        Wrench AddNewWrench(Wrench newWrench);
    }
}
