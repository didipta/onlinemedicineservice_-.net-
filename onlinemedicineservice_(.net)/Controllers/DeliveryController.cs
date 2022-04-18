using Businesslogic.Entity;
using Businesslogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace onlinemedicineservice__.net_.Controllers
{
    public class DeliveryController : ApiController
    {
        [Route("api/delivery/order/{id}")]
        [HttpGet]
        public HttpResponseMessage order(int id)
        {

            var data = myorderservice.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            

           

        }
        [Route("api/delivery/Editorder")]
        [HttpPut]
        public HttpResponseMessage Editorder(myordermodel p)
        {
            myorderservice.Editorder(p);
            if (p != null)
            {
                List<object> data = new List<object> { new { product = p } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "Not added");

        }
        [Route("api/delivery/profileshow/{id}")]
        [HttpGet]
        public HttpResponseMessage profileshows(int id)
        {
            var data = usersercice.profileshow(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/delivery/Editprofile/{id}")]
        [HttpPut]
        public HttpResponseMessage Editprofile(Systemusermodel p)
        {
            usersercice.EditProfile(p);
            if (p != null)
            {
                List<object> data = new List<object> { new { product = p } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not updated");

        }
    }
}
