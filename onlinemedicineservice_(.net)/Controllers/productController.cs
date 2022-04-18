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

        [Route("api/user/cartiteamdelet/{id}")]
        [HttpGet]
        public HttpResponseMessage getcartdelete(int id)
        {
            var data = Addtocartservice.getcartdelet(id);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/profileshow/{id}")]
        [HttpGet]
        public HttpResponseMessage profileshows(int id)
        {
            var data = usersercice.profileshow(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/user/orderproduct")]
        [HttpPost]
        public HttpResponseMessage orderproduct(orderitem o)
        {
             Addtocartservice.orderproduct(o.orderid, o.totaleprice, o.Paymenttype, o.userid, o.quantiy);
            return Request.CreateResponse(HttpStatusCode.OK,"All item add");

        }

        [Route("api/user/allorders/{name}")]
        [HttpGet]
        public HttpResponseMessage getallorder(string name)
        {
            var data = Addtocartservice.Getorder(name);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/orderdetails/{id}")]
        [HttpGet]
        public HttpResponseMessage getallorderdetails(int id)
        {
            var data = Addtocartservice.orderdetailes(id);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [Route("api/user/returnproduct/{id}")]
        [HttpGet]
        public HttpResponseMessage returnproduct(int id)
        {
            var data = Addtocartservice.orderd(id);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/returndetails")]
        [HttpPost]
        public HttpResponseMessage returndetails(returnpro r)
        {
            Addtocartservice.returnedit(r.id,r.reason,r.returnid,r.username);

            return Request.CreateResponse(HttpStatusCode.OK,"ok");
        }

        [Route("api/user/allreturn/{name}")]
        [HttpGet]
        public HttpResponseMessage getallreturn(string name)
        {
            var data = Addtocartservice.returns(name);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/returdetailsall/{id}")]
        [HttpGet]
        public HttpResponseMessage returdetailsall(int id)
        {
            var data = Addtocartservice.returndetails(id);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/profileimgch")]
        [HttpPost]
        public HttpResponseMessage profileimgchang(profileimg p)
        {
             usersercice.profileimgchange(p.id, p.imgfile);

            return Request.CreateResponse(HttpStatusCode.OK, "uploaed");
        }

    }
}
