using Businesslogic.Entity;
using DataLayer;
using System;
using DataLayer.datarazos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.Database;
using DataLayer.dataRepo;

namespace Businesslogic.Service
{
     public class usersercice
    {
        public static void Registertion(Systemusermodel s)
        {
            

            var config = new MapperConfiguration(
              cfg =>
              {
                  cfg.CreateMap<Systemusermodel , Systemuser>();


              }

              );


            Mapper mapper = new Mapper(config);
            var systemuser = mapper.Map<Systemuser>(s);

            var x = DataAccessFactory.userDataAccess().Add(systemuser);

        }
        public static Systemusermodel Loging(string username, string password)
        {
            var user = DataAccessFactory.LoginDataAccess().Getuser(username, password);

            var config = new MapperConfiguration(
              cfg =>
              {
                  cfg.CreateMap<Systemuser, Systemusermodel > ();
                  cfg.CreateMap<Token, Tokenmodel>();


              }

              );


                Mapper mapper = new Mapper(config);
                var systemuser = mapper.Map<Systemusermodel>(user);
              return systemuser;

        }

        public static Tokenmodel Token(Systemusermodel user)
        {
            

            var config = new MapperConfiguration(
              cfg =>
              {
                  cfg.CreateMap<Systemuser, Systemusermodel>();
                  cfg.CreateMap<Systemusermodel,Systemuser>();
                  cfg.CreateMap<Token, Tokenmodel>();


              }

              );
            Mapper mapper = new Mapper(config);
            var s = mapper.Map<Systemuser>(user);
            var token = DataAccessFactory.AuthDataAccess().Authenticate(s);
            
            var tokes = mapper.Map<Tokenmodel>(token);
            return tokes;

        }

        public static Tokenmodel CheckValidityToken(string token)
        {
            
            var config = new MapperConfiguration(
             cfg =>
             {
                 cfg.CreateMap<Systemuser, Systemusermodel>();
                 cfg.CreateMap<Systemusermodel, Systemuser>();
                 cfg.CreateMap<Token, Tokenmodel>();


             }

             );
            Mapper mapper = new Mapper(config);
            var rs = DataAccessFactory.AuthDataAccess().IsAuthenticated(token);

            var tokes = mapper.Map<Tokenmodel>(rs);
            return tokes;
        }

        public static void logout(int id)
        {


            DataAccessFactory.AuthDataAccess().Logout(id);

        }

        public static Systemusermodel profileshow(int id)
        {
            var user = DataAccessFactory.userDataAccess().Get(id);
            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Systemuser, Systemusermodel>();
                cfg.CreateMap<Systemusermodel, Systemuser>();
               


            }

            );
            Mapper mapper = new Mapper(config);
            var s = mapper.Map<Systemusermodel>(user);
            return s;
        }
<<<<<<< HEAD
        public static void EditProfile(Systemusermodel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Systemusermodel, Systemuser>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Systemuser>(p);
            systemuserrepo.EditProfile(data);
        }
=======

        public static void profileimgchange(int id,string imgpath)
        {
            var user = DataAccessFactory.userDataAccess().Get(id);

            user.U_profileimg = imgpath;
            DataAccessFactory.userDataAccess().Edit(user);

        }

>>>>>>> 50a298ef7a354cb39d49d0b3fb344bf23fe0a698
    }
    }

