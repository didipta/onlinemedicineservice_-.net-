using AutoMapper;
using Businesslogic.Entity;
using DataLayer;
using DataLayer.Database;
using DataLayer.datarazos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businesslogic.Service
{
    public class orderdetailservice
    {
        public static List<orderdetailssModel> Get()
        {

            var product = DataAccessFactory.ProductDataAccess().Get();
            var catgory = DataAccessFactory.GetorderDataAccess().Get();
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Orderdetail, orderdetailssModel>();
                 cfg.CreateMap<Product, productmodel>();
            }

            );

            Mapper mapper = new Mapper(config);
            var categories = mapper.Map<List<orderdetailssModel>>(catgory);
            return categories;

        }

    }
}
