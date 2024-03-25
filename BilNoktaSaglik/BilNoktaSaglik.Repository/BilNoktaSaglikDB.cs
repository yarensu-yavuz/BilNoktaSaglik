using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository
{
    public class BilNoktaSaglikDB:DbContext
    {


        public BilNoktaSaglikDB(DbContextOptions<BilNoktaSaglikDB> options):base(options)
        {
                
        }

        public DbSet<Rules> Rules { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Countries> Countries { get; set; }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }

        public DbSet<OurServices> OurServices{ get; set; }

        public DbSet<ServiceCategories> ServiceCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // modelBuilder.Entity<Rules>().HasKey(k => k.RulesId);
            //Configuration klasör altında ayarlar yapıldı, ordaki ayarlar çağrılması yeterlidir

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//???

            base.OnModelCreating(modelBuilder);
        }

    }
}
