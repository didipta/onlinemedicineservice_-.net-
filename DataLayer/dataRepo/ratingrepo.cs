using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    public class ratingrepo : IRepository<Rating, int>
    {
        Entities project;
        public ratingrepo(Entities db)
        {
            project = db;
        }
        public bool Add(Rating obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Rating obj)
        {
            throw new NotImplementedException();
        }

        public Rating Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rating> Get()
        {
            throw new NotImplementedException();
        }

        public Rating Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
