using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
   public class useraddtocartmodel : Systemusermodel
    {
        public List<addtocartmodel> addtocarts { get; set; }

        public useraddtocartmodel()
        {
            addtocarts = new List<addtocartmodel>();
        }
    }
}
