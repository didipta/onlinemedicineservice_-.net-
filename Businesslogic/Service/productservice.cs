﻿using AutoMapper;
using Businesslogic.Entity;
using DataLayer;
using DataLayer.Database;
using DataLayer.datarazos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Service
{
    public class productservice
    {
      public static List<productmodel> Getproduct()
        {
            
            var product = DataAccessFactory.ProductDataAccess().Get();
            var catgory = DataAccessFactory.orderdetailsDataAccess().Get();
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Category, orderdetailssmodel>();
                cfg.CreateMap<Product, productmodel>();
            }

            );
            
            Mapper mapper = new Mapper(config);
            var categories = mapper.Map<List<orderdetailssmodel>>(catgory);
            //ViewBag.categories = categories;
            //var products = Project.Products.ToList();
            var productss = mapper.Map<List<productmodel>>(product);
            return productss;

        }

        public static List<orderdetailssmodel> Getcategorie()
        {

            var product = DataAccessFactory.ProductDataAccess().Get();
            var catgory = DataAccessFactory.orderdetailsDataAccess().Get();
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Category, orderdetailssmodel>();
                cfg.CreateMap<Product, productmodel>();
            }

            );

            Mapper mapper = new Mapper(config);
            var categories = mapper.Map<List<orderdetailssmodel>>(catgory);
            return categories;

        }


        public static productcategorymodel products(int id)
        {
            var catgory = DataAccessFactory.orderdetailsDataAccess().Get(id);
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Category, productcategorymodel>();
                cfg.CreateMap<Product, productmodel>();
            }

            );
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<productcategorymodel>(catgory);
            return data;

        }


        public static productratingmodel ratings(int id)
        {
            var product = DataAccessFactory.ProductDataAccess().Get(id);
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Product, productratingmodel>();
                cfg.CreateMap<Rating, ratingmodel>();
            }

            );
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<productratingmodel>(product);
            return data;

        }

        public static productmodel Addtocart(int id)
        {

            var product = DataAccessFactory.ProductDataAccess().Get(id);
            var config = new MapperConfiguration(
           cfg =>
           {
               cfg.CreateMap<Category, orderdetailssmodel>();
               cfg.CreateMap<Product, productmodel>();
           }

           );


            Mapper mapper = new Mapper(config);
            var productss = mapper.Map<productmodel>(product);
            return productss;

        }

        public static productcategorymodel productitem(int id)
        {
            var catgory = DataAccessFactory.orderdetailsDataAccess().Getitem(id);
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Category, productcategorymodel>();
                cfg.CreateMap<Product, productmodel>();
            }

            );
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<productcategorymodel>(catgory);
            return data;

        }
        public static void AddProduct(productmodel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<productmodel, Product>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(p);
            productrepo.AddProduct(data);
        }
        public static void DeleteProduct(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<productmodel, Product>();
            });
            var mapper = new Mapper(config);

            productrepo.DeleteProduct(id);

        }
        public static void EditProduct(productmodel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<productmodel, Product>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(p);
            productrepo.EditProduct(data);
        }

    }
}
