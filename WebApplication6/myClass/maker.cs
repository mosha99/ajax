using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.myClass
{
    public class Maker
    {
        public singin maker()
        {
            singin x = new singin
            {
                Name = new Name
                {
                    Ferst_Name = null,
                    Ferst_Name_error = null,
                    Last_Name = null,
                    Last_Name_error = null,
                }
                ,
                Email = new Email
                {
                    email = null,
                    email_error = null
                }
                , Number = new Number
                {
                    number = null,
                    number_error = null
                }
                ,
                UserName = new UserName
                {
                    userName = null,
                    userName_error = null
                }
                ,
                Password = new Password
                {
                    password = null,
                    ConfirmPassword = null,
                    ConfirmPassword_error = null,
                    password_error = null
                }
                , data_dusername_error = null
                , data_email_error = null
                , data_number_error = null
                , acces=false

            };


            return x;
        }

    }
}