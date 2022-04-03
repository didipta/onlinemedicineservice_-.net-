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
        public static Systemusermodel Loging(string username, string password)
        {
            var user = DataAccessFactory.LoginDataAccess().Getuser(username, password);
            var config = new MapperConfiguration(
              cfg =>
              {
                  cfg.CreateMap<Systemuser, Systemusermodel > ();
                  
              }

              );


                Mapper mapper = new Mapper(config);
                var systemuser = mapper.Map<Systemusermodel>(user);
              return systemuser;

        }
    }
}
