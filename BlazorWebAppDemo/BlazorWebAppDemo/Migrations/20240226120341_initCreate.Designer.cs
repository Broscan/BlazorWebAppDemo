﻿// <auto-generated />
using BlazorWebAppDemo.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorWebAppDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240226120341_initCreate")]
    partial class initCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.HamburgerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hamburgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "God som fan",
                            ImageUrl = "https://www.max.se/contentassets/c4bc7d0b2980409db9e40bb48906ce8a/68657_hemsida-produkt_friscobbqchipotle_beef-meny_c1_2024_1920x1787px_se_dk_no_pl.jpg?width=1160&sharpen=5&sigma=1,4&threshold=0",
                            Name = "Frisco",
                            Price = 99
                        });
                });
#pragma warning restore 612, 618
        }
    }
}