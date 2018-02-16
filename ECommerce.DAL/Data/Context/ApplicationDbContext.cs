using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using ECommerce.DAL.Data.Entities;

namespace ECommerce.DAL.Data.Context
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
            : base("DbConnection")
        {
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>()); // Model değişikliğinde son güncel hali gelsin
      
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)  // 's' takılarını kaldırdı
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } // 60 tane tablo olsan hepsi eklenecek mi ?

    }
}
