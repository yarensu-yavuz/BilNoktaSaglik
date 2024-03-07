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
    public class RulesConfiguration : IEntityTypeConfiguration<Rules>
    {
        //Configuration ayarı=> DB de oluşturulacak tablo-column ayarlarını yapar
        //Entity Framework Library 
        public void Configure(EntityTypeBuilder<Rules> builder)
        {

            builder.HasKey(k => k.RulesId);//PK=> Primary Key=>
            builder.Property(k=>k.RulesId).UseIdentityColumn();
            builder.Property(k => k.RuleName).IsRequired();
            //builder.Property(k => k.RuleName).IsRequired(false);
        }
    }
}
