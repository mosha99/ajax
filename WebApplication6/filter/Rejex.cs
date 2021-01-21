using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication6.filter
{
    public class Rejex
    {
        public bool rejex(string input, string regex)
        {
            bool acces;
            if (input != null)
            {
                Regex filter = new Regex(regex);
                acces = filter.IsMatch(input);
            }
             else acces = false;
            return (acces);
        }
    }
}