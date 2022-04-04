using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    class Authrepo : IAuth

    {
        Entities project;
        public Authrepo(Entities db)
        {
            project = db;
        }
        public Token Authenticate(Systemuser user)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated(string token)
        {
            throw new NotImplementedException();
        }

        public void Logout(Systemuser user)
        {
            throw new NotImplementedException();
        }
    }
}
