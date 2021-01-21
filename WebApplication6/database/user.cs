using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.database
{
    
        public class user
        {
            
            public int id { set; get; }
            [MaxLength(30)]
            public string UserName { set; get; }
            [MaxLength(30)]
            public string ferstname { set; get; }
            [MaxLength(30)]
            public string LastName { set; get; }
            [MaxLength(11)]
            [MinLength(11)]
            public string number { set; get; }
            [MaxLength(30)]
            public string email { set; get; }
            [MaxLength(30)]
            public string Password { set; get; }

        
    }
}