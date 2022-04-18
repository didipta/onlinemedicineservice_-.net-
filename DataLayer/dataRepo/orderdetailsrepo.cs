using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    class orderdetailsrepo : IRepository<Orderdetail, int>
    {
        projectsEntities project = new projectsEntities();
        

        public orderdetailsrepo(projectsEntities db)
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
            throw new NotImplementedException();
        }

        public Orderdetail Get(int id)
        {
            var order = (from P in project.Orderdetails
                            where P.Id == id
                            select P).FirstOrDefault();
            return order;
        }

        public  List<Orderdetail> Get()
        {
            return project.Orderdetails.ToList();
        }

        public Orderdetail Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
