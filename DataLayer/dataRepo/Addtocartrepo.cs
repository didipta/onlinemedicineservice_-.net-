using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
   public class Addtocartrepo : IRepository<addtocart, int>, Iiteamget<addtocart, string>
    {
        Entities project;
        public Addtocartrepo(Entities db)
        {
            project = db;
        }
        public bool Add(addtocart obj)
        {
            project.addtocarts.Add(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            var Prodructs = (from P in project.addtocarts
                             where P.Id == id
                             select P).FirstOrDefault();

            project.addtocarts.Remove(Prodructs);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public bool Edit(addtocart obj)
        {
            project.Entry(obj).CurrentValues.SetValues(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public addtocart Get(int id)
        {
            var Prodruct = (from P in project.addtocarts
                            where P.P_id == id
                            select P).FirstOrDefault();
            return Prodruct;
        }

        public List<addtocart> Get()
        {
            throw new NotImplementedException();
        }

        public List<addtocart> Get(string name)
        {
            var cart = (from P in project.addtocarts
                        where P.U_username == name
                        select P).ToList();
            return cart;
        }


        public addtocart Getitem(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
