using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MODELO
{
   public class Context : DbContext
    {
        public Context() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Conexion>()
             .HasKey(_ => _.Id);

            modelBuilder.Entity<Plan>()
             .HasKey(_ => _.Id);
           
             

            //modelBuilder.Entity<City>()
            //    .HasKey(_ => _.IdCity)
            //    .HasRequired(_ => _.State).WithMany(_ => _.Cities)
            //    .HasForeignKey(_ => _.IdState);

        }

        public DbSet<Conexion> Conexiones { get; set; }
        public DbSet<Plan> Planes { get; set; }
        //public DbSet<City> Cities { get; set; }

    }

}

