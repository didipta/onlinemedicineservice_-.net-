using AutoMapper;
using Businesslogic.Entity;
using DataLayer;
using DataLayer.Database;
using DataLayer.datarazos;
using DataLayer.dataRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Service
{
    public class myorderservice
    {
        public static List<myordermodel> Get()
        {

            var order = DataAccessFactory.GetmyorderDataAccess().Get();
            var catgory = DataAccessFactory.GetorderDataAccess().Get();
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Orderdetail, orderdetailssmodel>();
                cfg.CreateMap<myorder, myordermodel>();
            }

            );

            Mapper mapper = new Mapper(config);
            
            var categories = mapper.Map<List<myordermodel>>(order);
            return categories;

        }
        public static myordermodel Get(int id)
        {

            var order = DataAccessFactory.GetmyorderDataAccess().Get(id);
            var catgory = DataAccessFactory.GetorderDataAccess().Get();
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Orderdetail, orderdetailssmodel>();
                cfg.CreateMap<myorder, myordermodel>();
            }

            );

            Mapper mapper = new Mapper(config);

            var categories = mapper.Map<myordermodel>(order);
            return categories;

        }
        public static void Addorder(myordermodel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<myordermodel, myorder>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<myorder>(p);
            myorderrepo.AddOrder(data);

        }
        public static void Editorder(myordermodel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<myordermodel, myorder>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<myorder>(p);
            myorderrepo.EditOrder(data);
        }
       
    }
}
