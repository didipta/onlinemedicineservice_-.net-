using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    class systemuserrepo : IRepository<Systemuser, int>, ILogin<Systemuser>
    {
        Entities project;
        public systemuserrepo(Entities db)
        {
            project = db;
        }
        public bool Add(Systemuser obj)
        {
            project.Systemusers.Add(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Systemuser obj)
        {
            project.Entry(obj).CurrentValues.SetValues(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
        }

        public Systemuser Get(int id)
        {
            var user = (from P in project.Systemusers
                            where P.Id == id
                            select P).FirstOrDefault();
            return user;
        }

        public List<Systemuser> Get()
        {
            throw new NotImplementedException();
        }

        public Systemuser Getuser(string username, string password)
        {
            var data = (from u in project.Systemusers
                        where u.U_username.Equals(username) &&
                        u.U_password.Equals(password)
                        select u).FirstOrDefault();
            return data;
        }

        public Systemuser Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
