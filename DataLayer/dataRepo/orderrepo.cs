using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
   public class orderrepo : IRepository<myorder, int>, Iiteamget<myorder, string>
    {
        Entities project;
        public orderrepo(Entities db)
        {
            project = db;
        }
        public bool Add(myorder obj)
        {
            project.myorders.Add(obj);
            project.SaveChanges();
            var cartitem = (from c in project.addtocarts
                            where c.U_username ==obj.U_username
                            select c).ToList();
            foreach (var item in cartitem)
            {
                Orderdetail detail = new Orderdetail();
                var productid = (from P in project.Products
                                 where P.Id == item.P_id
                                 select P).FirstOrDefault();
                productid.P_quantity = (productid.P_quantity - item.P_O_quantity);
                project.Entry(productid).CurrentValues.SetValues(productid);
                detail.Order_id = obj.Id;
                detail.P_id = item.P_id;
                detail.p_img = item.p_img;
                detail.P_tprice = item.P_tprice;
                detail.status = "Product is delivered";
                detail.U_username = item.U_username;
                detail.P_name = item.P_name;
                detail.P_O_quantity = item.P_O_quantity;
                project.Orderdetails.Add(detail);
                project.addtocarts.Remove(item);
                project.SaveChanges();


            }
            return true;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(myorder obj)
        {
            throw new NotImplementedException();
        }

        public myorder Get(int id)
        {
            var orders = (from P in project.myorders
                          where P.Id == id
                          select P).FirstOrDefault();
            return orders;
        }

        public List<myorder> Get()
        {
            throw new NotImplementedException();
        }

        public List<myorder> Get(string name)
        {
            var cart = (from P in project.myorders
                        where P.U_username == name
                        select P).ToList();
            return cart;
        }

        public myorder Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
