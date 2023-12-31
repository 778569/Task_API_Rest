﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240106092338_DataAnotationsDBJobRole")]
    partial class DataAnotationsDBJobRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "45",
                            City = "Alawwa",
                            FullName = "Kavinda Bandara",
                            JobRole = "Developer",
                            Street = "Street 1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "21",
                            City = "Jaffna",
                            FullName = "Shakuni Samanmalee",
                            JobRole = "QA",
                            Street = "Street 2"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "72",
                            City = "Kurunegala",
                            FullName = "Sam Don Karunarathne",
                            JobRole = "BA",
                            Street = "Street 3"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "55",
                            City = "Negombo",
                            FullName = "Harshana Disanayake",
                            JobRole = "Developer",
                            Street = "Street 1"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorId = 1,
                            Created = new DateTime(2024, 1, 6, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2849),
                            Description = "You need to get your book",
                            Due = new DateTime(2024, 1, 11, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2868),
                            Status = 0,
                            Title = "Get Books for the school"
                        },
                        new
                        {
                            ID = 2,
                            AuthorId = 1,
                            Created = new DateTime(2024, 1, 6, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2880),
                            Description = "You need to Super market",
                            Due = new DateTime(2024, 1, 11, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2882),
                            Status = 0,
                            Title = "Need to Vegitable - DB"
                        },
                        new
                        {
                            ID = 3,
                            AuthorId = 2,
                            Created = new DateTime(2024, 1, 6, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2887),
                            Description = "You need to go to Studio",
                            Due = new DateTime(2024, 1, 11, 14, 53, 38, 575, DateTimeKind.Local).AddTicks(2888),
                            Status = 0,
                            Title = "Need to Camera - DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
