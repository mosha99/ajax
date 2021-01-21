using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.filter
{
    public class F_password
    {
        public Password f_password(Password pas)
        {
            Rejex RJ = new Rejex();
            ErrorCollection error = new ErrorCollection();

            if(pas.password==null) pas.password_error = error.error_box(11, false);
            else
            {
                bool acces;
                acces = RJ.rejex(pas.password, "^(?=^.{6,}$)((?=.*[A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z]))^.*$");
                pas.password_error = error.error_box(4, acces);
            }
            if (pas.ConfirmPassword == null) pas.ConfirmPassword_error = error.error_box(11, false);
            else
            {
                if (pas.password != pas.ConfirmPassword) pas.ConfirmPassword_error = error.error_box(5, false);
                else pas.ConfirmPassword_error = null;
            }
            return pas;

        }
    }
}