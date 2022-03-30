using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
   public class productcategorymodel : categorymodel
    {
        public List<productmodel> Products { get; set; }

        public productcategorymodel()
        {
            Products = new List<productmodel>();
        }

    }
   
}
