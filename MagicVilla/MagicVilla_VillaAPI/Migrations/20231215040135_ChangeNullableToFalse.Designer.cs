﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231215040135_ChangeNullableToFalse")]
    partial class ChangeNullableToFalse
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9906),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9901)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9910),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9908)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9914),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqft = 750,
                            UpdatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9912)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9918),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqft = 900,
                            UpdatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9916)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9921),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UpdatedDate = new DateTime(2023, 12, 14, 22, 1, 35, 235, DateTimeKind.Local).AddTicks(9920)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}