using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
   public class systemuserrepo : IRepository<Systemuser, int>, ILogin<Systemuser>
    {
        projectsEntities project = new projectsEntities();
        public systemuserrepo(projectsEntities db)
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
<<<<<<< HEAD
            projectsEntities project = new projectsEntities();
            var ds = project.Systemusers.FirstOrDefault(e => e.Id == obj.Id);
            project.Entry(ds).CurrentValues.SetValues(obj);
            project.SaveChanges();
            return true;
=======
            project.Entry(obj).CurrentValues.SetValues(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
>>>>>>> 50a298ef7a354cb39d49d0b3fb344bf23fe0a698
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
        public static void EditProfile(Systemuser pro)
        {
            projectsEntities project = new projectsEntities();
            var ds = project.Systemusers.FirstOrDefault(e => e.Id == pro.Id);
            project.Entry(ds).CurrentValues.SetValues(pro);
            project.SaveChanges();

        }
    }
}
