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
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    
        {  
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(k => k.UsersId);
            builder.Property(k => k.UsersId).UseIdentityColumn();
            builder.Property(k => k.UserName).IsRequired();
            builder.Property(k => k.UserPassword).IsRequired();
            //1 Rule'de 1'den fazla User olabilir=> 1-Sonsuz
            builder.HasOne(k => k.Rule).WithMany(k => k.Users).HasForeignKey(k => k.RuleId);
        }
    }
}
