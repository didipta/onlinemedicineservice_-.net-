using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    public class returndetailes : IRepository<returndeteli, int>
    {
        Entities project;
        public returndetailes(Entities db)
        {
            project = db;
        }
        public bool Add(returndeteli obj)
        {
            project.returndetelis.Add(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(returndeteli obj)
        {
            throw new NotImplementedException();
        }

        public returndeteli Get(int id)
        {
            var orders = (from P in project.returndetelis
                          where P.return_id == id
                          select P).FirstOrDefault();
            return orders;
        }

        public List<returndeteli> Get()
        {
            throw new NotImplementedException();
        }

        public returndeteli Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
