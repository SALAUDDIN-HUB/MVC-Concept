﻿// <auto-generated />
using EmartMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartMvc.Migrations.Category
{
    [DbContext(typeof(CategoryContext))]
    partial class CategoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartMvc.Models.Category", b =>
                {
                    b.Property<int>("C_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C_details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("C_id");

                    b.ToTable("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
