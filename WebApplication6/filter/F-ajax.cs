using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;
using WebApplication6.myClass;

namespace WebApplication6.filter
{
    public class F_ajax
    {
        public ajax f_ajax(ajax model)
        {
            Connector filter = new Connector();
            Maker make = new Maker();
            singin user = new singin();
            user = make.maker();

            user.Name.Ferst_Name = "moein";
            
            switch (model.name)
            {
                
                case "Name.Ferst_Name" :
                    user.Name.Ferst_Name = model.valu;
                    user =filter.connector(user);
                    model.error = user.Name.Ferst_Name_error;
                    break;
                case "Name.Last_Name" :
                    user.Name.Last_Name = model.valu;
                    user = filter.connector(user);
                    model.error = user.Name.Last_Name_error;
                    break;
                case"Email.email":
                    user.Email.email = model.valu;
                    user = filter.connector(user);
                    model.error = user.Email.email_error;
                    model.data_error = user.data_email_error;
                    break;
                case"Number.number" :
                    user.Number.number = model.valu;
                    user = filter.connector(user);
                    model.error = user.Number.number_error;
                    model.data_error = user.data_email_error;
                    break;
                case"Password.password":
                    user.Password.password = model.valu;
                    user = filter.connector(user);
                    model.error = user.Password.password_error;
                    break;
                case"Password.ConfirmPassword"   :
                    user.Password.ConfirmPassword = model.valu;
                    user = filter.connector(user);
                    model.error = null;
                    break;
                case"UserName.userName"          :
                    user.UserName.userName= model.valu;
                    user = filter.connector(user);
                    model.error = user.UserName.userName_error;
                    model.data_error = user.data_dusername_error;
                    break;
               
            }

            return model;
        }
    }
}