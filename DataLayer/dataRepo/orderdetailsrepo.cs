using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
   public class orderdetailsrepo : IRepository<Orderdetail, int>
    {

        Entities project;
        public orderdetailsrepo(Entities db)
        {
            project = db;
        }
        public bool Add(Orderdetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Orderdetail obj)
        {
            project.Entry(obj).CurrentValues.SetValues(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public Orderdetail Get(int id)
        {
            var orders = (from P in project.Orderdetails
                          where P.Id == id
                          select P).FirstOrDefault();
            return orders;
        }

        public List<Orderdetail> Get()
        {
            throw new NotImplementedException();
        }

        public Orderdetail Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
