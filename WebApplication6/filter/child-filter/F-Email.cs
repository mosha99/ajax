using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.filter.child_filter
{
    public class F_Email
    {
        public Email f_Email(Email email)
        {
            Rejex RJ = new Rejex();
            ErrorCollection error = new ErrorCollection();
            if(email.email==null) email.email_error = error.error_box(11, false);
            else
            {
                bool acces;
                acces = RJ.rejex(email.email, "^(([a-zA-Z0-9._%-]{3,15})+@([a-zA-Z0-9.-]{5,16})+.[a-zA-Z]{2,4})*$");
                email.email_error = error.error_box(6, acces);
            }
           
            
            return email;
        }
    }
}