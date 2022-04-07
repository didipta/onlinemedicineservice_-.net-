using AutoMapper;
using Businesslogic;
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
        public HttpResponseMessage Login(Systemusermodel u)
        {
            var user = usersercice.Loging(u.U_username, u.U_password);
            var tokes = usersercice.Token(u);
            if (tokes != null)
            {
                List<object> data = new List<object> { new { user = user, tokes = tokes  } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
           

            
        }

        [Route("api/user/Registertion")]
        [HttpPost]
        public HttpResponseMessage Registertion(user s)
        {
            Systemusermodel ss = new Systemusermodel
            {
                U_name = s.Firstname + " " + s.LastName,
                U_address = s.address,
                U_email = s.U_email,
                U_username = s.U_username,
                U_profileimg = "pro.png",
                U_phone = s.U_phone,
                pharmacyname = "Null",
                Usertype = "Customer",
                U_password = s.password
            };

            usersercice.Registertion(ss);

            return Request.CreateResponse(HttpStatusCode.OK, ss);


        }

        [Route("api/user/Logout/{id}")]
        [HttpGet]
        public HttpResponseMessage Logout(int id)
        {
            usersercice.logout(id);
            return Request.CreateResponse(HttpStatusCode.NotFound, "User is logout");



        }


    }
}
