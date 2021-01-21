using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.database;
using WebApplication6.Models;

namespace WebApplication6.myClass
{
    public class AddData
    {
        public void  dataAdd(singin model)
        {

            var data = new mycontext();
            data.users.Add(new user
            {
                ferstname = (model.Name.Ferst_Name)   ,
                LastName  = (model.Name.Last_Name)    ,
                number    = (model.Number.number)     ,
                UserName  = (model.UserName.userName) ,
                Password  = (model.Password.password) ,
                email     = (model.Email.email)
            });
            data.SaveChanges();
        }
         
         
    }
}