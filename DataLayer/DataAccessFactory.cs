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
            return new productrepo();
        }

        public static IRepository<Category, int> CategoryDataAccess()
        {
            return new categoryrepo();
        }

    }
}
