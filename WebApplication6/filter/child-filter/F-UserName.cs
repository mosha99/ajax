using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.filter.child_filter
{
    public class F_UserName
    {
        public UserName f_UserName(UserName userName)
        {
            Rejex RJ = new Rejex();
            ErrorCollection error = new ErrorCollection();
            if(userName.userName==null) userName.userName_error = error.error_box(11, false);
            else
            {
                bool acces;
                acces = RJ.rejex(userName.userName, "^[a-zA-Z0-9]{8,30}$");
                userName.userName_error = error.error_box(7, acces);
            }
            
            return userName;
        }
    }
}