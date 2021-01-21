using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication6.database
{
   
        public class mycontext : DbContext
        {
            public mycontext() : base("userData") { }
            public DbSet<user> users { set; get; }

        }
    
}