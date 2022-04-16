using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IAuth
    {
        Token Authenticate(Systemuser user);
        Token IsAuthenticated(string token);
        void Logout(int id);
    }
}
