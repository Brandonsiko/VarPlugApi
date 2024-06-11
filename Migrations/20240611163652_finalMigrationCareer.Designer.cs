﻿// <auto-generated />
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
    [Migration("20240611163652_finalMigrationCareer")]
    partial class finalMigrationCareer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VarPlugApi.Model.Career", b =>
                {
                    b.Property<int>("Career_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Career_Id"), 1L, 1);

                    b.Property<string>("Career_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Career_Id");

                    b.ToTable("career");
                });

            modelBuilder.Entity("VarPlugApi.Model.CareerFaculty", b =>
                {
                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.HasKey("CareerId", "FacultyId");

                    b.HasIndex("FacultyId");

                    b.ToTable("CareerFaculty");
                });

            modelBuilder.Entity("VarPlugApi.Model.CareerUniverities", b =>
                {
                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<int>("CareerUniversityId")
                        .HasColumnType("int");

                    b.HasKey("CareerId", "UniversityId");

                    b.HasIndex("UniversityId");

                    b.ToTable("CareerUniverities");
                });

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

                    b.Property<int>("ProvinceId")
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

            modelBuilder.Entity("VarPlugApi.Model.CareerFaculty", b =>
                {
                    b.HasOne("VarPlugApi.Model.Career", "Career")
                        .WithMany("careerFaculties")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VarPlugApi.Model.Faculty", "Faculty")
                        .WithMany("careerFaculties")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("VarPlugApi.Model.CareerUniverities", b =>
                {
                    b.HasOne("VarPlugApi.Model.Career", "Career")
                        .WithMany("CareerUniversities")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VarPlugApi.Model.University", "University")
                        .WithMany("careerUniverities")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Career");

                    b.Navigation("University");
                });

            modelBuilder.Entity("VarPlugApi.Model.Faculty", b =>
                {
                    b.HasOne("VarPlugApi.Model.University", "university")
                        .WithMany("OfferedFaculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("university");
                });

            modelBuilder.Entity("VarPlugApi.Model.University", b =>
                {
                    b.HasOne("VarPlugApi.Model.Province", "province")
                        .WithMany("universities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("province");
                });

            modelBuilder.Entity("VarPlugApi.Model.Career", b =>
                {
                    b.Navigation("CareerUniversities");

                    b.Navigation("careerFaculties");
                });

            modelBuilder.Entity("VarPlugApi.Model.Faculty", b =>
                {
                    b.Navigation("careerFaculties");
                });

            modelBuilder.Entity("VarPlugApi.Model.Province", b =>
                {
                    b.Navigation("universities");
                });

            modelBuilder.Entity("VarPlugApi.Model.University", b =>
                {
                    b.Navigation("OfferedFaculties");

                    b.Navigation("careerUniverities");
                });
#pragma warning restore 612, 618
        }
    }
}
