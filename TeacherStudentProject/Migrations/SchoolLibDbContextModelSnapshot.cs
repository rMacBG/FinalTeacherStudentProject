﻿// <auto-generated />
using System;
using FinalTeacherStudentProject.Data.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TeacherStudentProject.Migrations
{
    [DbContext(typeof(SchoolLibDbContext))]
    partial class SchoolLibDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Email", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailInformatiuon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmailTypeId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Grade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("GradesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("GradesId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Speciality", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialityTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityTypeId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Email", b =>
                {
                    b.HasOne("FinalTeacherStudentProject.Data.Models.Email", "EmailType")
                        .WithMany()
                        .HasForeignKey("EmailTypeId");

                    b.HasOne("FinalTeacherStudentProject.Data.Models.Student", null)
                        .WithMany("StudentEmails")
                        .HasForeignKey("StudentId");

                    b.HasOne("FinalTeacherStudentProject.Data.Models.Teacher", null)
                        .WithMany("TeacherEmails")
                        .HasForeignKey("TeacherId");

                    b.Navigation("EmailType");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Grade", b =>
                {
                    b.HasOne("FinalTeacherStudentProject.Data.Models.Grade", "Grades")
                        .WithMany()
                        .HasForeignKey("GradesId");

                    b.Navigation("Grades");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Speciality", b =>
                {
                    b.HasOne("FinalTeacherStudentProject.Data.Models.Speciality", "SpecialityType")
                        .WithMany()
                        .HasForeignKey("SpecialityTypeId");

                    b.HasOne("FinalTeacherStudentProject.Data.Models.Teacher", null)
                        .WithMany("Specialities")
                        .HasForeignKey("TeacherId");

                    b.Navigation("SpecialityType");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Student", b =>
                {
                    b.Navigation("StudentEmails");
                });

            modelBuilder.Entity("FinalTeacherStudentProject.Data.Models.Teacher", b =>
                {
                    b.Navigation("Specialities");

                    b.Navigation("TeacherEmails");
                });
#pragma warning restore 612, 618
        }
    }
}
