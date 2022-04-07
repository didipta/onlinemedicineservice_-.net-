using Businesslogic.Entity;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.Database;

namespace Businesslogic.Service
{
   public class Addtocartservice
    {
        public static bool Addtocart(int id,string username,int quantity)
        {
            var Prodructs= DataAccessFactory.ProductDataAccess().Get(id);
            var addto = DataAccessFactory.AddtocartDataAccess().Get(id);
            var x = "khcdakhdvack";
            int total = (addto.P_O_quantity + quantity);
            if(addto.U_username== username)
            {
                addto.P_O_quantity= total;
                addto.P_tprice = (Int32.Parse(Prodructs.P_price) * total).ToString();
                var data = DataAccessFactory.AddtocartDataAccess().Edit(addto);
            }
            else
            {
                addtocartmodel ad = new addtocartmodel
                {
                    p_img = Prodructs.P_img,
                    P_name = Prodructs.P_name,
                    P_O_quantity = quantity,
                    P_id = Prodructs.Id,
                    P_tprice = (Int32.Parse(Prodructs.P_price) * quantity).ToString(),
                    U_username = username

                };
                var config = new MapperConfiguration(
              cfg =>
              {
                  cfg.CreateMap<addtocart, addtocartmodel>();
                  cfg.CreateMap<addtocartmodel, addtocart>();



              }

              );
                Mapper mapper = new Mapper(config);
                var addd = mapper.Map<addtocart>(ad);
                 var data = DataAccessFactory.AddtocartDataAccess().Add(addd);

                
            }

            return true ;

        }

        public static List<addtocartmodel> getcart(string name)
        {
            var cart = DataAccessFactory.GetiteamDataAccess().Get(name);
            var config = new MapperConfiguration(
           cfg =>
           {
               cfg.CreateMap<addtocart,addtocartmodel > ();
               



           }

           );
            Mapper mapper = new Mapper(config);
            var carts = mapper.Map<List<addtocartmodel>>(cart);
            return carts;

        }

        }
}
