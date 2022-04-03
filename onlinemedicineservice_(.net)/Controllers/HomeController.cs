using AutoMapper;
using Businesslogic;
using Businesslogic.Service;
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

            var product = productservice.productitem(id);
            var rating = productservice.ratings(id);

            double x = 0;
            foreach (var item in rating.Ratings)
            {
                x += item.rating1;
            }

            double y = (x / rating.Ratings.Count());
           var totalrat = y;

            List<object> data = new List<object> { new { totalrat = totalrat, rating = rating, product= product } };
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/Login")]
        [HttpPost]
        public HttpResponseMessage Login(user u)
        {
            var data = usersercice.Loging(u.U_username, u.U_password);
            return Request.CreateResponse(HttpStatusCode.OK, data);

            
        }


    }
}
