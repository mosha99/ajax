using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Number
    {
        [DataType(DataType.PhoneNumber)]
        public string number { get; set; }
        public string number_error { get; set; }
    }
}