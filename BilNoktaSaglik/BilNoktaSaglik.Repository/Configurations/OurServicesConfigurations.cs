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
    public class OurServicesConfiguration : IEntityTypeConfiguration<OurServices>
    {
        public void Configure(EntityTypeBuilder<OurServices> builder)
        {


            builder.HasKey(k => k.OurServicesId);
            builder.Property(k => k.OurServicesId).UseIdentityColumn();//Identity
            builder.Property(k => k.OurServicesName).IsRequired();
            builder.Property(k => k.OurServicesDescription).IsRequired();


            //ServicesCategoriesId 'yi ve UserId'yi foreign key yapmalıyım.
        }
    }

}

