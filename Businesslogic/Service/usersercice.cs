using Businesslogic.Entity;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.Database;

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

        public static bool CheckValidityToken(string token)
        {
            var rs = DataAccessFactory.AuthDataAccess().IsAuthenticated(token);
            return rs;
        }

        public static void logout(int id)
        {


            DataAccessFactory.AuthDataAccess().Logout(id);

        }
    }
}
