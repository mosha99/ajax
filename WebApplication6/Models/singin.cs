using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication6.Models
{
    public class singin
    {
        public Name Name { get; set; }
        public UserName UserName { get; set; }
        public Number Number { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public string data_dusername_error { get; set; }
        public string data_number_error { set; get; }
        public string data_email_error { set; get; }
        public bool acces { get; set; }

    }
}