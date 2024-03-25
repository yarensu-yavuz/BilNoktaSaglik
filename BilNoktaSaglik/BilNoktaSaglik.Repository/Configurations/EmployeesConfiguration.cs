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
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {

            builder.HasKey(k => k.EmployeeId);//PK=> Primary Key=>
            builder.Property(k => k.EmployeeId).UseIdentityColumn();//Identity
            builder.Property(k => k.EmployeeName).IsRequired();
            builder.Property(k => k.EmployeePhoneNumber).IsRequired();
            //builder.Property(k => k.RuleName).IsRequired(false);
        }
    }
}
