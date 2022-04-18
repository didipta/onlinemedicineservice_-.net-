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
using System.Web.Http.Description;

namespace onlinemedicineservice__.net_.Controllers
{
    [userauth]
    public class StaffController : ApiController
    {
        [Route("api/staff")]
        [HttpGet]
        public HttpResponseMessage Gettproducts()
        {

            var product = productservice.Getproduct();
            

            return Request.CreateResponse(HttpStatusCode.OK, product);
        }
        [Route("api/staff/Create")]
        [HttpPost]
        public HttpResponseMessage AddProducts(productmodel p)
        {

             productservice.AddProduct(p);
            if (p != null)
            {
                List<object> data = new List<object> { new { product = p } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }

            return Request.CreateResponse(HttpStatusCode.NotFound, " no product");

        }

        [Route("api/staff/Delete/{Id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteProduct(int id)
        {
            productservice.DeleteProduct(id);
            return Request.CreateResponse(HttpStatusCode.NotFound, " Deleted");
        }

        [Route("api/staff/Edit")]
        [HttpPut]

        public HttpResponseMessage EditProduct(productmodel p)
        {
            productservice.EditProduct(p);
            if (p != null)
            {
                List<object> data = new List<object> { new { product = p } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not updated");
        }
        [Route("api/staff/orderdetail")]
        [HttpGet]
        public HttpResponseMessage orderdetail()
        {

            var product = orderdetailservice.Get();
            return Request.CreateResponse(HttpStatusCode.OK, product);

        }
        [Route("api/staff/order")]
        [HttpGet]
        public HttpResponseMessage order()
        {

            var product = myorderservice.Get();
            return Request.CreateResponse(HttpStatusCode.OK, product);

        }
       
       
        [Route("api/staff/profileshow/{id}")]
        [HttpGet]
        public HttpResponseMessage profileshows(int id)
        {
            var data = usersercice.profileshow(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/staff/Editprofile/{id}")]
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
        [Route("api/staff/Addorder")]
        [HttpPost]
        public HttpResponseMessage Addorder(myordermodel p)
        {
            myorderservice.Addorder(p);
            if (p != null)
            {
                List<object> data = new List<object> { new { product = p } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
               
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not added");

        }
        [Route("api/staff/Editorder")]
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

    }
}
