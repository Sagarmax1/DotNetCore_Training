﻿// <auto-generated />
using LoginService.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LoginService.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserName");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
