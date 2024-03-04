using ApiYoutube.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ApiYoutube.Data
{
    public class DataBaseContext:DbContext    
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        
         public  DbSet<Posts>Posts { get; set; }

        
        }   
    }
