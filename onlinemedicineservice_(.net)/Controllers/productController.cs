using Businesslogic.Entity;
using Businesslogic.Service;
using onlinemedicineservice__.net_.Auth;
using onlinemedicineservice__.net_.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace onlinemedicineservice__.net_.Controllers
{
    [EnableCors("*", "*", "*")]
    [userauth]
    public class productController : ApiController
    {
       
        [Route("api/user/addtocart")]
        [HttpPost]
        public HttpResponseMessage Addtocart(cart cart )
        {
            var data=Addtocartservice.Addtocart(cart.productid, cart.username, cart.item_quantity);
           
            return Request.CreateResponse(HttpStatusCode.OK, data );
        }
        [Route("api/user/cartiteam/{name}")]
        [HttpGet]
        public HttpResponseMessage getcart(string name)
        {
            var data = Addtocartservice.getcart(name);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
