using CorcoranPresidentsBackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace CorcoranPresidentsBackEnd.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PresidentsController : ApiController
    {

        PresidentsRepository presidentsRepo = new PresidentsRepository();

        [HttpGet]
        public IHttpActionResult GetPresidents()
        {
            var jsonSerializer = new JavaScriptSerializer();
            string jsonResult = jsonSerializer.Serialize(presidentsRepo.GetPresidentsFromDb(null));
            return Ok(jsonResult);
        }

        [HttpGet]
        public IHttpActionResult GetPresidents(bool asc)
        {
            var jsonSerializer = new JavaScriptSerializer();
            string jsonResult = null;
            if (asc) jsonResult = jsonSerializer.Serialize(presidentsRepo.GetPresidentsFromDb(true));
            else jsonResult = jsonSerializer.Serialize(presidentsRepo.GetPresidentsFromDb(false));
            return Ok(jsonResult);
        }
    }
}
