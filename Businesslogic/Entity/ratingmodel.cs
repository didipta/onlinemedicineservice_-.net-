using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
   public class ratingmodel
    {
        public int id { get; set; }
        public double rating1 { get; set; }
        public string Review { get; set; }
        public int Product_id { get; set; }
        public string username { get; set; }
    }
}
