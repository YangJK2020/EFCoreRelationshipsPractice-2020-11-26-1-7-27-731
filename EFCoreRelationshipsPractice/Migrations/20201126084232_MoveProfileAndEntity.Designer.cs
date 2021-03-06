﻿// <auto-generated />
using System;
using EFCoreRelationshipsPractice.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreRelationshipsPractice.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20201126084232_MoveProfileAndEntity")]
    partial class MoveProfileAndEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFCoreRelationshipsPractice.NewFolder.CompanyEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ProfileID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EFCoreRelationshipsPractice.NewFolder.EmployeeEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyEntityID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.HasIndex("CompanyEntityID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCoreRelationshipsPractice.NewFolder.ProfileEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CertId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("RegisteredCapital")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("EFCoreRelationshipsPractice.NewFolder.CompanyEntity", b =>
                {
                    b.HasOne("EFCoreRelationshipsPractice.NewFolder.ProfileEntity", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID");
                });

            modelBuilder.Entity("EFCoreRelationshipsPractice.NewFolder.EmployeeEntity", b =>
                {
                    b.HasOne("EFCoreRelationshipsPractice.NewFolder.CompanyEntity", null)
                        .WithMany("Employees")
                        .HasForeignKey("CompanyEntityID");
                });
#pragma warning restore 612, 618
        }
    }
}
