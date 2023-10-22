﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team_Turtle.Models;

#nullable disable

namespace Team_Turtle.Migrations
{
    [DbContext(typeof(SWCDbContext))]
    partial class SWCDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Team_Turtle.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "School of Applied Computer Science and Information Technology"
                        });
                });

            modelBuilder.Entity("Team_Turtle.Models.Program", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramId"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("ProgramLengthLength")
                        .HasColumnType("int");

                    b.Property<string>("ProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProgramLengthLength");

                    b.ToTable("Programs");

                    b.HasData(
                        new
                        {
                            ProgramId = 1,
                            DepartmentId = 1,
                            Length = 2,
                            ProgramName = "Computer Programming"
                        },
                        new
                        {
                            ProgramId = 2,
                            DepartmentId = 1,
                            Length = 3,
                            ProgramName = "Computer Programming and Analysis"
                        });
                });

            modelBuilder.Entity("Team_Turtle.Models.ProgramLength", b =>
                {
                    b.Property<int>("Length")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Length"));

                    b.HasKey("Length");

                    b.ToTable("ProgramLengths");

                    b.HasData(
                        new
                        {
                            Length = 1
                        },
                        new
                        {
                            Length = 2
                        },
                        new
                        {
                            Length = 3
                        });
                });

            modelBuilder.Entity("Team_Turtle.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Level")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgramId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProgramId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DepartmentId = 1,
                            Email = "jseo9123@conestogac.on.ca",
                            Level = 3,
                            Name = "Juhwan Seo",
                            Password = "12345678",
                            ProgramId = 2
                        });
                });

            modelBuilder.Entity("Team_Turtle.Models.Program", b =>
                {
                    b.HasOne("Team_Turtle.Models.Department", "Department")
                        .WithMany("Programs")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Team_Turtle.Models.ProgramLength", "ProgramLength")
                        .WithMany("Programs")
                        .HasForeignKey("ProgramLengthLength");

                    b.Navigation("Department");

                    b.Navigation("ProgramLength");
                });

            modelBuilder.Entity("Team_Turtle.Models.Student", b =>
                {
                    b.HasOne("Team_Turtle.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team_Turtle.Models.Program", "Program")
                        .WithMany("Students")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Team_Turtle.Models.Department", b =>
                {
                    b.Navigation("Programs");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Team_Turtle.Models.Program", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Team_Turtle.Models.ProgramLength", b =>
                {
                    b.Navigation("Programs");
                });
#pragma warning restore 612, 618
        }
    }
}
