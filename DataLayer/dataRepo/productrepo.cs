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
        projectsEntities project= new projectsEntities();
        public productrepo(projectsEntities db)
        {
            project = db;
        }
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
            project.Entry(obj).CurrentValues.SetValues(obj);
            if (project.SaveChanges() != 0) return true;
            return false;
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
        public static void AddProduct(Product po)
        {

            projectsEntities project = new projectsEntities();
            project.Products.Add(po);
            var result = project.SaveChanges();




        }

        public static void DeleteProduct(int id)
        {
            projectsEntities project = new projectsEntities();
            var pro = project.Products.Find(id);
            project.Products.Remove(pro);
            project.SaveChanges();

        }
        public static void EditProduct(Product pro)
        {
            projectsEntities project = new projectsEntities();
            var ds = project.Products.FirstOrDefault(e => e.Id == pro.Id);
            project.Entry(ds).CurrentValues.SetValues(pro);
            project.SaveChanges();

        }
    }











}
   

