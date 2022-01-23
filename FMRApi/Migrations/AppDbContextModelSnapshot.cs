﻿// <auto-generated />
using System;
using FMRApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FMRApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FMRApi.DataAccess.Customers", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("id");

                    b.Property<string>("customerId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("customerId");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("fullName");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isDeleted");

                    b.Property<int>("updateDate")
                        .HasColumnType("int")
                        .HasColumnName("updateDate");

                    b.HasKey("id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FMRApi.Models.Address", b =>
                {
                    b.Property<string>("customerId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("customerId");

                    b.Property<string>("Customersid")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<int>("houseNum")
                        .HasColumnType("int")
                        .HasColumnName("houseNum");

                    b.Property<int>("pob")
                        .HasColumnType("int")
                        .HasColumnName("pob");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("street");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("type");

                    b.Property<int>("zip")
                        .HasColumnType("int")
                        .HasColumnName("zip");

                    b.HasKey("customerId");

                    b.HasIndex("Customersid");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Phone", b =>
                {
                    b.Property<string>("customerId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("customerId");

                    b.Property<string>("Customersid")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("type");

                    b.HasKey("customerId");

                    b.HasIndex("Customersid");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<string>("customerId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("customerId");

                    b.Property<string>("Customersid")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<decimal>("deposit")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("deposit");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("description");

                    b.Property<decimal>("interestPercents")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("interestPercents");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<int>("productId")
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    b.HasKey("customerId");

                    b.HasIndex("Customersid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Products", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("id");

                    b.Property<string>("customerId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("customerId");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<decimal>("deposit")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("deposit");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("description");

                    b.Property<decimal>("interestPercents")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("interestPercents");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isDeleted");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<int>("productId")
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    b.Property<int>("updateDate")
                        .HasColumnType("int")
                        .HasColumnName("updateDate");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FMRApi.Models.Address", b =>
                {
                    b.HasOne("FMRApi.DataAccess.Customers", null)
                        .WithMany("addresses")
                        .HasForeignKey("Customersid");
                });

            modelBuilder.Entity("Phone", b =>
                {
                    b.HasOne("FMRApi.DataAccess.Customers", null)
                        .WithMany("phones")
                        .HasForeignKey("Customersid");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("FMRApi.DataAccess.Customers", null)
                        .WithMany("products")
                        .HasForeignKey("Customersid");
                });

            modelBuilder.Entity("FMRApi.DataAccess.Customers", b =>
                {
                    b.Navigation("addresses");

                    b.Navigation("phones");

                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}