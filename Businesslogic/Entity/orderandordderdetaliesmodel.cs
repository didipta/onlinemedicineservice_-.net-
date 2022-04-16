using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
    public class orderandordderdetaliesmodel : ordermodel
    {
        public List<oderdetailesmodel> Orderdetails { get; set; }

        public orderandordderdetaliesmodel()
        {
            Orderdetails = new List<oderdetailesmodel>();
        }

    }
}
