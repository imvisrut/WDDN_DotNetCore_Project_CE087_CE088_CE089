﻿// <auto-generated />
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Keyboard",
                            Description = "PC GAMING KEYBOARD AND GAMING MOUSE COMBO: Includes Redragon RGB Backlit Computer Gaming Keyboard and RGB Backlit Gaming Mouse. ALL-IN-ONE PC GAMER VALUE KIT, Fantastic for Gamers (New Improved Version)",
                            ImageURL1 = "https://m.media-amazon.com/images/I/71uIslKmtoL._AC_SL1500_.jpg",
                            ImageURL2 = "https://m.media-amazon.com/images/I/71H6y1GGbAL._AC_SL1500_.jpg",
                            MainImageURL = "https://m.media-amazon.com/images/I/71kr3WAj1FL._AC_SL1500_.jpg",
                            Name = "Redragon Keyboard",
                            Price = 4000,
                            Stock = 200
                        },
                        new
                        {
                            Id = 2,
                            Category = "Keyboard",
                            Description = "Mini 60% Keyboard: RK61 mini 60% gaming keyboard is a ultra-compact layout with 61 keys makes you a neat desktop with your organized gears on, even folks have nothing to do with Minimalist will dive into its tiny practical design. Tips you might want to know is that keyboard without numpad is most FPS gamers' choice, more spaces left for mouse movements.",
                            ImageURL1 = "https://m.media-amazon.com/images/I/71ji90FcW4L._AC_SL1500_.jpg",
                            ImageURL2 = "https://m.media-amazon.com/images/I/71TYtZyvCrS._AC_SL1500_.jpg",
                            MainImageURL = "https://m.media-amazon.com/images/I/61mBAMckzJL._AC_SL1500_.jpg",
                            Name = "RK ROYAL KLUDGE",
                            Price = 3000,
                            Stock = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}