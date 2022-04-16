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
            
            if(addto!=null && addto.U_username== username)
            {
                int total = (addto.P_O_quantity + quantity);
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

        public static bool getcartdelet(int id)
        {
            var cart = DataAccessFactory.AddtocartDataAccess().Delete(id);
            return cart;
        }
        public static void orderproduct(string orderid, string totaleprice, string Paymenttype, int id, string quantiy)
        {

            var uid = DataAccessFactory.userDataAccess().Get(id);
            var cart = DataAccessFactory.GetiteamDataAccess().Get(uid.U_username);

            ordermodel order = new ordermodel();
            order.Oder_id = orderid;
            order.totale_price = totaleprice;
            order.Paymanttype = Paymenttype;
            order.U_username = uid.U_username;
            order.User_id = uid.Id;
            order.O_status = "Your Order is processing";
            order.totale_iteam = quantiy;

            var config = new MapperConfiguration(
                  cfg =>
                  {
                      cfg.CreateMap<myorder, ordermodel>();
                      cfg.CreateMap<ordermodel, myorder>();




                  }

                  );
            Mapper mapper = new Mapper(config);
            var orders = mapper.Map<myorder>(order);

            DataAccessFactory.orderDataAcces().Add(orders);





        }

        public static List<ordermodel> Getorder(string name)
        {
            var cart = DataAccessFactory.orderGetiteamDataAccess().Get(name);
            var config = new MapperConfiguration(
           cfg =>
           {
               cfg.CreateMap<myorder, ordermodel>();




           }

           );
            Mapper mapper = new Mapper(config);
            var carts = mapper.Map<List<ordermodel>>(cart);
            return carts;

        }

        public static orderandordderdetaliesmodel orderdetailes(int id)
        {
            var order = DataAccessFactory.orderDataAcces().Get(id);
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<myorder, orderandordderdetaliesmodel>();
                cfg.CreateMap<Orderdetail, oderdetailesmodel>();
            }

            );
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<orderandordderdetaliesmodel>(order);
            return data;

        }
        public static oderdetailesmodel orderd(int id)
        {
            var order = DataAccessFactory.orderdetailsAccess().Get(id);
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<oderdetailesmodel, Orderdetail>();
                cfg.CreateMap<Orderdetail, oderdetailesmodel>();
            }

            );
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<oderdetailesmodel>(order);
            return data;

        }

        public static void returnedit(int id,string reason, string returnid,string username)
        {
            var order = DataAccessFactory.orderdetailsAccess().Get(id);
            order.status = "Retrun the product";
            DataAccessFactory.orderdetailsAccess().Edit(order);
            var product = DataAccessFactory.ProductDataAccess().Get(order.P_id);
            product.P_quantity = (product.P_quantity + order.P_O_quantity);
            DataAccessFactory.ProductDataAccess().Edit(product);
            returnmodel returno = new returnmodel();
            returno.reason = reason;
            returno.statuse = "Return is processing";
            returno.return_id = returnid;
            returno.date = DateTime.Now;
            returno.username = username;
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Returnproduct, returnmodel>();
                cfg.CreateMap<returnmodel, Returnproduct>();
                cfg.CreateMap<returndeteli, returndetails>();
                cfg.CreateMap<returndetails, returndeteli>();
            }

            );
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<Returnproduct>(returno);
            DataAccessFactory.ReturnproducAccess().Add(data);
            returndetails returnd = new returndetails();
            returnd.p_id = order.P_id;
            returnd.p_name = order.P_name;
            returnd.p_price = order.P_tprice;
            returnd.p_quantity = order.P_O_quantity;
            returnd.return_id = data.id;
            var datar = mapper.Map<returndeteli>(returnd);
            DataAccessFactory.returndetailesAccess().Add(datar);




        }

        public static List<returnmodel> returns(string name)
        {
            var cart = DataAccessFactory.GetiteamReturnDataAccess().Get(name);
            var config = new MapperConfiguration(
         cfg =>
         {
             cfg.CreateMap<Returnproduct, returnmodel>();
             cfg.CreateMap<returnmodel, Returnproduct>();
            
         }

         );
            Mapper mapper = new Mapper(config);
            var carts = mapper.Map<List<returnmodel>>(cart);
            return carts;
        }

        public static returndetails returndetails(int id)
        {
            var cart = DataAccessFactory.returndetailesAccess().Get(id);
            var config = new MapperConfiguration(
         cfg =>
         {
             cfg.CreateMap<returndeteli, returndetails>();
             cfg.CreateMap<returndetails, returndeteli>();

         }

         );
            Mapper mapper = new Mapper(config);
            var carts = mapper.Map<returndetails>(cart);
            return carts;
        }

    }
}
