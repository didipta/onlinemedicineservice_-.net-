using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface ILogin< X >
    {
        X Getuser(string username, string password);
    }
}
