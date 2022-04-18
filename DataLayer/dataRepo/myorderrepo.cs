using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    public class myorderrepo : IRepository<myorder, int>
    {
        projectsEntities project;
       

        public myorderrepo(projectsEntities db)
        {
            project = db;
        }

        public bool Add(myorder obj)
        {
            throw new NotImplementedException();
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
            var order = (from P in project.myorders
                            where P.deliveryman == id
                            select P).FirstOrDefault();
            return order;
        }

        public List<myorder> Get()
        {
            var order = (from P in project.myorders
                         select P).ToList();
            return order;
        }

        public myorder Getitem(int id)
        {
            throw new NotImplementedException();
        }
        public static void AddOrder(myorder po)
        {

            projectsEntities project = new projectsEntities();
            project.myorders.Add(po);
            var result = project.SaveChanges();
            



        }
        public static void EditOrder(myorder pro)
        {
            projectsEntities project = new projectsEntities();
            var ds = project.myorders.FirstOrDefault(e => e.Id == pro.Id);
            project.Entry(ds).CurrentValues.SetValues(pro);
            project.SaveChanges();

        }
      

    }
}
