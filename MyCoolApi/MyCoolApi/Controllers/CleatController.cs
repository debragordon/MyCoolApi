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
    public class CleatController : ApiController
    {
        readonly ICleatRepository _cleatRepo;

        public CleatController()
        {
            _cleatRepo = new CleatRepository();
        }

        public CleatController(ICleatRepository cleatRepo)
        {
            _cleatRepo = cleatRepo;
        }

        [HttpGet]
        [Route("api/cleat/{id}")]
        public HttpResponseMessage DisplayCleatById(string id)
        {
            var cleat = _cleatRepo.GetByPartNumber(id);

            if (cleat == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The cleat with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, cleat);
        }

        [HttpGet]
        [Route("api/cleats")]
        public HttpResponseMessage DisplayAllCleats()
        {
            var cleats = _cleatRepo.GetAllCleats();

            if (cleats == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"There are no cleats");
            }

            return Request.CreateResponse(HttpStatusCode.OK, cleats);
        }

        [HttpPost]
        [Route("api/cleat/{newCleat}")]
        public HttpResponseMessage AddNewCleat(Cleat newCleat)
        {
            var addedCleat = _cleatRepo.AddNewCleat(newCleat);

            if (addedCleat == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified,
                    $"Your item {newCleat} was not added.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, addedCleat);
        }

    }
}
