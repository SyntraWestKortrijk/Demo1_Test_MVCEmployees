﻿// <auto-generated />
using System;
using EmployeesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeesApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200419181835_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeesApp.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d36f3fa4-5d03-43d2-98d8-ff7a1dc3a296"),
                            AccountNumber = "123-3452134543-32",
                            Age = 30,
                            Name = "Mark"
                        },
                        new
                        {
                            Id = new Guid("f3d3ba87-3d7c-49ed-99df-1469a5cd0284"),
                            AccountNumber = "123-9384613085-55",
                            Age = 28,
                            Name = "Evelin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
