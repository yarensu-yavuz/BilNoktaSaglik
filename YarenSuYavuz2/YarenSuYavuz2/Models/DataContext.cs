using Microsoft.EntityFrameworkCore;

namespace YarenSuYavuz2.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Kasiyer> Kasiyers { get; set; }
        public DbSet<Kategori> Kategoris{ get; set; }
        public DbSet<Tedarikçi> Tedarikcis { get; set; }
        public DbSet<Stok_> Stoks { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Satilan_Urunler> Satilan_Urunlers { get; set; }



    }

    }
