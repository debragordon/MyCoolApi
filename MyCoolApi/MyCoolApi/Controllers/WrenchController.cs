using MyCoolApi.DAL;
using MyCoolApi.Interfaces;
using MyCoolApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyCoolApi.Controllers
{
    public class WrenchController : ApiController
    {
        readonly IWrenchRepository _wrenchRepo;

        public WrenchController()
        {
            _wrenchRepo = new WrenchRepository();
        }

        public WrenchController(IWrenchRepository wrenchRepo)
        {
            _wrenchRepo = wrenchRepo;
        }

        [HttpGet]
        [Route("api/wrnech/{id}")]
        public HttpResponseMessage DisplayWrenchById(string id)
        {
            var wrench = _wrenchRepo.GetByPartNumber(id);

            if (wrench == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The wrench with an id of {id} does not exist.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, wrench);
        }

        [HttpGet]
        [Route("api/wrenches")]
        public HttpResponseMessage DisplayAllWrenches()
        {
            var wrenches = _wrenchRepo.GetAllWrenches();

            if (wrenches == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"There are no wrenches");
            }

            return Request.CreateResponse(HttpStatusCode.OK, wrenches);
        }

        [HttpPost]
        [Route("api/wrench/{newWrench}")]
        public HttpResponseMessage AddNewCleat(Wrench newWrench)
        {
            var addedWrench = _wrenchRepo.AddNewWrench(newWrench);

            if (addedWrench == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified,
                    $"Your item {addedWrench} was not added.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, addedWrench);
        }
    }
}
