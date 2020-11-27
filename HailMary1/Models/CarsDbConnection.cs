using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HailMary1.Models
{
    public class CarsDbConnection:DbContext
    {
       public CarsDbConnection() : base("CarsDb")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>;
        }*/
         public DbSet<Car> Cars { get; set; }
    }
}