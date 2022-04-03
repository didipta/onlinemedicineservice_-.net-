using DataLayer.Database;
using DataLayer.datarazos;
using DataLayer.dataRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    
   public class DataAccessFactory
    {
        static Entities db = new Entities();

        public static IRepository<Product, int> ProductDataAccess()
        {
            return new productrepo(db);
        }

        public static IRepository<Systemuser, int> userDataAccess()
        {
            return new systemuserrepo(db);
        }

        public static ILogin<Systemuser> LoginDataAccess()
        {
            return new systemuserrepo(db);
        }

        public static IRepository<Category, int> CategoryDataAccess()
        {
            return new categoryrepo(db);
        }

    }
}
