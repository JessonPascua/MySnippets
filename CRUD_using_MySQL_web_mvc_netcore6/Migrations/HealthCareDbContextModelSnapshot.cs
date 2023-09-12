﻿// <auto-generated />
using System;
using CRUD_using_MySQL_web_mvc_netcore6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_using_MySQL_web_mvc_netcore6.Migrations
{
    [DbContext(typeof(HealthCareDbContext))]
    partial class HealthCareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Entities.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INT");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Physicians", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<string>("DoctorFirstName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("DoctorLastName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("INT");

                    b.HasKey("DoctorId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Physicians");
                });

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Specializations", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<sbyte>("Status")
                        .HasColumnType("TINYINT");

                    b.Property<string>("Type")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Entities.Patients", b =>
                {
                    b.HasOne("CRUD_using_MySQL_web_mvc_netcore6.Models.Physicians", "Physician")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physician");
                });

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Physicians", b =>
                {
                    b.HasOne("CRUD_using_MySQL_web_mvc_netcore6.Models.Specializations", "Specialization")
                        .WithMany("Physicians")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Physicians", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("CRUD_using_MySQL_web_mvc_netcore6.Models.Specializations", b =>
                {
                    b.Navigation("Physicians");
                });
#pragma warning restore 612, 618
        }
    }
}
