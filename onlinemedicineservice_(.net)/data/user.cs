using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlinemedicineservice__.net_.data
{
    public class user
    {
       
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string U_phone { get; set; }
        public string address { get; set; }
        public string U_username { get; set; }
        public string U_email { get; set; }
        public string password { get; set; }

        public string cpassword { get; set; }



    }
}