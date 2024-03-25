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
        }
    }
}
