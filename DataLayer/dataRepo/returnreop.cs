using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    public class returnreop : IRepository<Returnproduct, int>, Iiteamget<Returnproduct, string>
    {
    
        Entities project;
        public returnreop(Entities db)
        {
            project = db;
        }
        public bool Add(Returnproduct obj)
        {
            project.Returnproducts.Add(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Returnproduct obj)
        {
            throw new NotImplementedException();
        }

        public Returnproduct Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Returnproduct> Get()
        {
            throw new NotImplementedException();
        }

        public List<Returnproduct> Get(string name)
        {
            var cart = (from P in project.Returnproducts
                        where P.username == name
                        select P).ToList();
            return cart;
        }

        public Returnproduct Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
