using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IRepository<X, ID>
    {
        bool Add(X obj);
        bool Edit(X obj);
        X Get(ID id);

        X Getitem(ID id);
        List<X> Get();
        bool Delete(ID id);


    }
   
}
