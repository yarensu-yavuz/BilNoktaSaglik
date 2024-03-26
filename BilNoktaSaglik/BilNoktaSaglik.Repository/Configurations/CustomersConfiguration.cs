using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CustomersConfiguration : IEntityTypeConfiguration<Customers>
{
    public void Configure(EntityTypeBuilder<Customers> builder)
    {
        builder.HasKey(k => k.CustomersId);
        builder.Property(k => k.CustomersId).UseIdentityColumn();
        builder.Property(k => k.CustomersName).IsRequired();
        builder.Property(k => k.CustomersSurname).IsRequired();
        // builder.Property(k => k.CustomersDescription)();//Gerekli değil yapacaktım
        builder.Property(k => k.PassportNumber).IsRequired();
        builder.Property(k => k.Age).IsRequired();
        builder.Property(k => k.Gender).IsRequired();
        builder.Property(k => k.Weight).IsRequired();
        builder.Property(k => k.Height).IsRequired();
        builder.Property(k => k.TREnterDate).IsRequired();
        builder.Property(k => k.IsAccomodation).IsRequired();
        builder.Property(k => k.ExtraDiscomfort).IsRequired();
        // builder.Property(k => k.ExtraDiscomfort).IsRequired();//Gerekli değil yapacaktım
        builder.Property(k => k.AddedTime).IsRequired();
        builder.Property(k => k.PhoneNumber).IsRequired();

        //Foreign Key yapmaya çalıştım olmadı:
        //  builder.HasOne(k => k.Countries)
        //.WithMany(c => c.Customers)
        //.HasForeignKey(k => k.CountriesId);
    }
}

