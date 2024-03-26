using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Configurations
{
    public class ServiceCategoriesConfiguration : IEntityTypeConfiguration<ServiceCategories>
    {
        public void Configure(EntityTypeBuilder<ServiceCategories> builder)
        {


            builder.HasKey(k => k.ServicesCategoriesId);
            builder.Property(k => k.ServicesCategoriesId).UseIdentityColumn();//Identity
            builder.Property(k => k.ServicesCategoriesName).IsRequired();
            builder.Property(k => k.CategoriesDescription).IsRequired();
            builder.Property(k => k.AddedTime).IsRequired();



        }
    }
}
