using AutoMapper;
using Businesslogic;
using Businesslogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace onlinemedicineservice__.net_.Controllers
{
    [EnableCors("*","*","*")]
    public class HomeController : ApiController
    {
        [Route("api/user/homepage")]
        [HttpGet]
        public HttpResponseMessage Homepage()
        {
         
            var product = productservice.Getproduct();
            var categories = productservice.Getcategorie();
            List<object> data = new List<object> { new { products = product, categorie = categories } };

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/product/{id}")]
        [HttpGet]
        public HttpResponseMessage products(int id)
        {

            var product = productservice.products(id);
            

            return Request.CreateResponse(HttpStatusCode.OK, product);
        }


        [Route("api/user/addtocart/{id}")]
        [HttpGet]
        public HttpResponseMessage Addtocart(int id)
        {

            var product = productservice.Addtocart(id);


            return Request.CreateResponse(HttpStatusCode.OK, product);
        }
    }
}
