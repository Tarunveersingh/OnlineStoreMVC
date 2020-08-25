using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreMVC.Models
{
    public class Login
    {
        //here we use the getter setter method to pass the value from front-end to back-end 

        public String txt_Name { get; set; }
        public String txt_Password { get; set; }
    }
}