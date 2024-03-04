using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Data.Entity;
using YarenSuYavuzFinal.Models.Entities;
using YarenSuYavuzFinal.Models.Entities.User;

namespace YarenSuYavuzFinal.DataContext
{
    public class RestorantDbContext: System.Data.Entity.DbContext
    {
        public RestorantDbContext(DbContextOptions<RestorantDbContext> options) : base(options) 
        { 
             
        
            }
        public DbSet<Garson> Garson { get; set; }
        public DbSet<Register> Register { get; set; }
        public DbSet <Restorant> Restorant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet <UserRol>UserRol { get; set; }
        public DbSet <Malzemeler> Malzemeler { get; set; }
    }
}
