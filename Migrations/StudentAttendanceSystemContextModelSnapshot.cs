﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAttendanceSystem.Data;

namespace StudentAttendanceSystem.Migrations
{
    [DbContext(typeof(StudentAttendanceSystemContext))]
    partial class StudentAttendanceSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentAttendanceSystem.Models.Admin", b =>
                {
                    b.Property<string>("AdminId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AdminUsername")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("StudentAttendanceSystem.Models.Attendance", b =>
                {
                    b.Property<string>("AttendanceId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("AttendanceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AttendanceStatus")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AttendanceId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("StudentAttendanceSystem.Models.Leave", b =>
                {
                    b.Property<string>("LeaveId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("LeaveApplyDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LeaveEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeaveReason")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("LeaveStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LeaveId");

                    b.HasIndex("StudentId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("StudentAttendanceSystem.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("StudentContact")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentGender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("StudentPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentType")
                        .HasColumnType("int");

                    b.Property<string>("StudentUsername")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentAttendanceSystem.Models.Attendance", b =>
                {
                    b.HasOne("StudentAttendanceSystem.Models.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentAttendanceSystem.Models.Leave", b =>
                {
                    b.HasOne("StudentAttendanceSystem.Models.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
