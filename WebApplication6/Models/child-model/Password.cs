using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Password
    {
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string password_error { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string ConfirmPassword_error { get; set; }
    }
}