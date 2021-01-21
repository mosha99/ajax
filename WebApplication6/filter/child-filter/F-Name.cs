using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.filter
{
    public class F_Name
    {
        public Name f_Name(Name name)
        {
            Rejex RJ=new Rejex();
            ErrorCollection error = new ErrorCollection();
            bool Facces , Lacces;
            if(name.Ferst_Name==null) name.Ferst_Name_error = error.error_box(11, false);
            else
            {
                Facces = RJ.rejex(name.Ferst_Name, "^[ ا-ی]" + "{3,16}$");
                name.Ferst_Name_error = error.error_box(1, Facces);
            }
            if (name.Last_Name == null) name.Last_Name_error = error.error_box(11, false);
            else
            {
                Lacces = RJ.rejex(name.Last_Name, "^[ ا-ی]" + "{3,16}$");
                name.Last_Name_error = error.error_box(2, Lacces);
            }
            return name;
        }
    }
}