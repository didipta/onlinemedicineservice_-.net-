using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
   public class returnmodel
    {
        public int id { get; set; }
        public string return_id { get; set; }
        public string reason { get; set; }
        public System.DateTime date { get; set; }
        public string statuse { get; set; }
        public string username { get; set; }
    }
}
