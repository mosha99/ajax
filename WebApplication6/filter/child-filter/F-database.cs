using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.database;
using WebApplication6.Models;


namespace WebApplication6.filter.child_filter
{
    public class F_database
    {
        public string f_Udatabase(singin model)
        {
           
            ErrorCollection error_box = new ErrorCollection();
            bool acces;
            var data = new mycontext();
            
            var U = data.users.FirstOrDefault(m => m.UserName == model.UserName.userName);
            
            if (U != null) acces = false; else acces = true;
            model.data_dusername_error = error_box.error_box(8, acces);
            if(model.UserName.userName==null) model.data_dusername_error=null;
            return model.data_dusername_error;
        }
        public string f_Ndatabase(singin model)
        {

            ErrorCollection error_box = new ErrorCollection();
            bool acces;
            var data = new mycontext();
            var N = data.users.FirstOrDefault(m => m.number == model.Number.number);

            if (N != null) acces = false; else acces = true;
            model.data_number_error = error_box.error_box(9, acces);
            if (model.Number.number == null) model.data_number_error = null;
            return model.data_number_error;
        }
        public string f_Edatabase(singin model)
        {

            ErrorCollection error_box = new ErrorCollection();
            bool acces;
            var data = new mycontext();
            var E = data.users.FirstOrDefault(m => m.email == model.Email.email);

            if (E != null) acces = false; else acces = true;
            model.data_email_error = error_box.error_box(10, acces);
            if (model.Email.email == null) model.data_email_error = null;
            return model.data_email_error;
        }
    }
}