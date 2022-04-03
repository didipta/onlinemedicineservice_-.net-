using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic.Entity
{
   public class productratingmodel : productmodel
    {
        public List<ratingmodel> Ratings { get; set; }

    public productratingmodel()
        {
            Ratings = new List<ratingmodel>();
        }
    }
}
