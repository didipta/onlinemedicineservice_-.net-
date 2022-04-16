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

        public static IRepository<addtocart, int> AddtocartDataAccess()
        {
            return new Addtocartrepo(db);
        }
        public static Iiteamget<addtocart, string> GetiteamDataAccess()
        {
            return new Addtocartrepo(db);
        }
        public static IAuth AuthDataAccess()
        {
            return new Authrepo(db);
        }

        public static IRepository<myorder, int> orderDataAcces()
        {
            return new orderrepo(db);
        }
        public static Iiteamget<myorder, string> orderGetiteamDataAccess()
        {
            return new orderrepo(db);
        }

          public static IRepository<Orderdetail, int> orderdetailsAccess()
        {
            return new orderdetailsrepo(db);
        }

        

        public static IRepository<Returnproduct, int> ReturnproducAccess()
        {
            return new returnreop(db);
        }

        public static IRepository<returndeteli, int> returndetailesAccess()
        {
            return new returndetailes(db);
        }
        public static Iiteamget<Returnproduct, string> GetiteamReturnDataAccess()
        {
            return new returnreop(db);
        }

    }
}
