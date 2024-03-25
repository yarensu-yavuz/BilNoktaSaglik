﻿// <auto-generated />
using System;
using BilNoktaSaglik.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BilNoktaSaglik.Repository.Migrations
{
    [DbContext(typeof(BilNoktaSaglikDB))]
    [Migration("20240321190221_add_countryTable")]
    partial class add_countryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BilNoktaSaglik.Core.BilNoktaSaglikDatabase.Countries", b =>
                {
                    b.Property<int>("CountriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountriesId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountriesId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BilNoktaSaglik.Core.BilNoktaSaglikDatabase.Rules", b =>
                {
                    b.Property<int>("RulesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RulesId"));

                    b.Property<string>("RuleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RulesId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("BilNoktaSaglik.Core.BilNoktaSaglikDatabase.Users", b =>
                {
                    b.Property<int>("UsersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsersId"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsersId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
