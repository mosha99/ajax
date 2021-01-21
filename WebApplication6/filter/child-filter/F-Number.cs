using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.filter
{
    public class F_Number
    {
        public Number f_Number(Number number)
        {
            Rejex RJ = new Rejex();
            ErrorCollection error = new ErrorCollection();
            bool acces;
            if (number.number != null)
            {
                if (number.number.Length == 11)
                {
                    acces = RJ.rejex(number.number, "^09");
                    number.number_error = error.error_box(3, acces);
                }
                else
                {
                    number.number_error = error.error_box(3, false);
                }
            }
            else
            {
                number.number_error = error.error_box(11, false);
            }
            return number;
        }
    }
}