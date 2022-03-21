using AutoMapper;
using onlinemedicineservice__.net_.Models.Database;
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
            Entities Project = new Entities();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Category, categorymodel>();
                    cfg.CreateMap<Product, productmodel>();
                }

                );
            var categorie = Project.Categories.ToList();
            Mapper mapper = new Mapper(config);
            var categories = mapper.Map<List<categorymodel>>(categorie);
            //ViewBag.categories = categories;
            var products = Project.Products.ToList();
            var product = mapper.Map<List<productmodel>>(products);
            /*if (Session["Usernmae"] != null)
            {
                //ViewBag.username = Session["Usernmae"].ToString();
            }
            else
            {
                ViewBag.username = " ";
            }
            */

            List<object> data = new List<object> { new { products = product, categorie = categories } };

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
