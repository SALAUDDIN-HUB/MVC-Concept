﻿// <auto-generated />
using EmartMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartMvc.Migrations.Seller
{
    [DbContext(typeof(SellerContext))]
    partial class SellerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartMvc.Models.Seller", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("S_abtcompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_comapnyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_emailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_gstin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("S_mobilenum")
                        .HasColumnType("bigint");

                    b.Property<string>("S_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_postaladdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photopath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SID");

                    b.ToTable("Sellers");
                });
#pragma warning restore 612, 618
        }
    }
}
