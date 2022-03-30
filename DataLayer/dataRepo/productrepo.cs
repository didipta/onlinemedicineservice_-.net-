using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.datarazos
{
    public class productrepo : IRepository<Product, int>
    {
        Entities project = new Entities();
        public bool Add(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Product obj)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            var Prodruct = (from P in project.Products
                            where P.Id == id
                            select P).FirstOrDefault();
            return Prodruct;

        }

        public List<Product> Get()
        {
            
            return project.Products.ToList();
           
        }

        public Product Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
   
}
