using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebApplication6.filter.child_filter;
using WebApplication6.Models;
using WebApplication6.myClass;

namespace WebApplication6.filter
{
    public class Connector
    {
        public singin connector(singin model)
        {
            F_Email f_Email         = new F_Email();
            F_Name f_Name           = new F_Name();
            F_Number f_number       = new F_Number();
            F_password f_password   = new F_password();
            F_UserName f_username   = new F_UserName();
            F_database f_database   = new F_database();
            AddData add             = new AddData();
            
            model.Email      =   f_Email.f_Email          (model.Email)     ;
            model.Name       =   f_Name.f_Name            (model.Name)      ;
            model.Number     =   f_number.f_Number        (model.Number)    ;
            model.Password   =   f_password.f_password    (model.Password)  ;
            model.UserName   =   f_username.f_UserName    (model.UserName)  ;
            model.data_dusername_error = f_database.f_Udatabase    (model)  ;
            model.data_number_error    = f_database.f_Ndatabase    (model)  ;
            model.data_email_error     = f_database.f_Edatabase    (model)  ;
            model.acces      = 
                                (
                                    model.Email.email_error                 == null &
                                    model.Name.Ferst_Name_error             == null &
                                    model.Name.Last_Name_error              == null &
                                    model.Number.number_error               == null &
                                    model.Password.password_error           == null &
                                    model.Password.ConfirmPassword_error    == null &
                                    model.UserName.userName_error           == null &
                                    model.data_email_error                  == null &
                                    model.data_dusername_error              == null &
                                    model.data_number_error                 == null 
                                );
            if (model.acces) add.dataAdd(model);
            if (model.acces) FormsAuthentication.SetAuthCookie(model.UserName.userName, false);
            return model;
        }

    }
}