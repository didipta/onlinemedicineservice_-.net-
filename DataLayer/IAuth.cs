using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IAuth
    {
        bool Authenticate(string username, string password);
    }
}
