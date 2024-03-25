using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Configurations
{
    public class CountriesConfiguration : IEntityTypeConfiguration<Countries>
    {

        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.HasKey(k => k.CountriesId);//PK=> Primary Key=>
            builder.Property(k => k.CountriesId).UseIdentityColumn();//Identity
            builder.Property(k => k.CountryName).IsRequired();
        }
    }
}
