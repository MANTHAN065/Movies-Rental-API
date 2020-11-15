using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Vidly.Models
{
    public class DbContext_Model : DbContext
    {
       public DbContext_Model()
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
     
    }
}