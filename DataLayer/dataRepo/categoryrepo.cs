using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
   public class categoryrepo : IRepository<Category, int>
    {
        Entities project;
        public categoryrepo(Entities db)
        {
            project = db;
        }

        public bool Add(Category obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Category obj)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            var cate = (from C in project.Categories
                        where C.Id == id
                        select C).FirstOrDefault();

            return cate;
        }

            public List<Category> Get()
        {
            Entities project = new Entities();
            var Categorie = project.Categories.ToList();
            return Categorie;

        }
        public Category Getitem(int id)
        {
            var Prodruct = (from P in project.Products
                            where P.Id == id
                            select P).FirstOrDefault();

            var cate = (from C in project.Categories
                        where C.Id ==Prodruct.P_categorie_id
                        select C).FirstOrDefault();

            return cate;

        }
    }
}
