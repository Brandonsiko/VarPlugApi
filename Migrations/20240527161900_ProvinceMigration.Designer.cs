﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VarPlugApi.Data;

#nullable disable

namespace VarPlugApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240527161900_ProvinceMigration")]
    partial class ProvinceMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VarPlugApi.Model.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("VarPlugApi.Model.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinceId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("province");
                });

            modelBuilder.Entity("VarPlugApi.Model.University", b =>
                {
                    b.Property<int>("UNI_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UNI_Id"), 1L, 1);

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Portal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("UNI_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UNI_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UNI_Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("universities");
                });

            modelBuilder.Entity("VarPlugApi.Model.Faculty", b =>
                {
                    b.HasOne("VarPlugApi.Model.University", "university")
                        .WithMany("OfferedFaculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("university");
                });

            modelBuilder.Entity("VarPlugApi.Model.University", b =>
                {
                    b.HasOne("VarPlugApi.Model.Province", null)
                        .WithMany("universities")
                        .HasForeignKey("ProvinceId");
                });

            modelBuilder.Entity("VarPlugApi.Model.Province", b =>
                {
                    b.Navigation("universities");
                });

            modelBuilder.Entity("VarPlugApi.Model.University", b =>
                {
                    b.Navigation("OfferedFaculties");
                });
#pragma warning restore 612, 618
        }
    }
}
