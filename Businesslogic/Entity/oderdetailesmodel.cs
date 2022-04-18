using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
   public class oderdetailesmodel
    {
        public int Id { get; set; }
        public int Order_id { get; set; }
        public int P_id { get; set; }
        public int P_O_quantity { get; set; }
        public string P_tprice { get; set; }
        public string U_username { get; set; }
        public string P_name { get; set; }
        public string status { get; set; }
        public string p_img { get; set; }
    }
}
