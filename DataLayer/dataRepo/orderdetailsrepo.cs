using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
<<<<<<< HEAD
    class orderdetailsrepo : IRepository<Orderdetail, int>
    {
        projectsEntities project = new projectsEntities();
        

        public orderdetailsrepo(projectsEntities db)
        {
            project = db;
        }

=======
   public class orderdetailsrepo : IRepository<Orderdetail, int>
    {

        Entities project;
        public orderdetailsrepo(Entities db)
        {
            project = db;
        }
>>>>>>> 50a298ef7a354cb39d49d0b3fb344bf23fe0a698
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
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            project.Entry(obj).CurrentValues.SetValues(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
>>>>>>> 50a298ef7a354cb39d49d0b3fb344bf23fe0a698
        }

        public Orderdetail Get(int id)
        {
<<<<<<< HEAD
            var order = (from P in project.Orderdetails
                            where P.Id == id
                            select P).FirstOrDefault();
            return order;
        }

        public  List<Orderdetail> Get()
        {
            return project.Orderdetails.ToList();
=======
            var orders = (from P in project.Orderdetails
                          where P.Id == id
                          select P).FirstOrDefault();
            return orders;
        }

        public List<Orderdetail> Get()
        {
            throw new NotImplementedException();
>>>>>>> 50a298ef7a354cb39d49d0b3fb344bf23fe0a698
        }

        public Orderdetail Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
