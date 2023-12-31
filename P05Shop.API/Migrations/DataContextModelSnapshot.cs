﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int?>("ProductDetailsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 712.021981759007m,
                            ReleaseDate = new DateTime(2022, 11, 8, 14, 3, 12, 304, DateTimeKind.Local).AddTicks(8639),
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "7",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 839.010165513032m,
                            ReleaseDate = new DateTime(2023, 5, 21, 10, 41, 45, 941, DateTimeKind.Local).AddTicks(493),
                            Title = "Handcrafted Steel Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "1",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 198.083692779804m,
                            ReleaseDate = new DateTime(2022, 9, 9, 5, 35, 29, 214, DateTimeKind.Local).AddTicks(2476),
                            Title = "Handmade Granite Table"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "1",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 160.643399712929m,
                            ReleaseDate = new DateTime(2023, 4, 10, 17, 48, 59, 573, DateTimeKind.Local).AddTicks(3836),
                            Title = "Handmade Wooden Table"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "0",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 359.887736376788m,
                            ReleaseDate = new DateTime(2022, 10, 11, 19, 7, 11, 303, DateTimeKind.Local),
                            Title = "Intelligent Steel Salad"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "8",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 181.360829243139m,
                            ReleaseDate = new DateTime(2023, 4, 25, 6, 54, 44, 412, DateTimeKind.Local).AddTicks(7264),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "1",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 938.297015022625m,
                            ReleaseDate = new DateTime(2022, 11, 24, 6, 6, 56, 822, DateTimeKind.Local).AddTicks(7298),
                            Title = "Unbranded Steel Car"
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "3",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 223.882037785315m,
                            ReleaseDate = new DateTime(2023, 2, 16, 21, 21, 24, 510, DateTimeKind.Local).AddTicks(9505),
                            Title = "Tasty Plastic Cheese"
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "0",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 249.172251003875m,
                            ReleaseDate = new DateTime(2022, 8, 8, 13, 20, 39, 967, DateTimeKind.Local).AddTicks(6983),
                            Title = "Handcrafted Fresh Sausages"
                        },
                        new
                        {
                            Id = 10,
                            Barcode = "1",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 905.322284099796m,
                            ReleaseDate = new DateTime(2023, 5, 31, 5, 2, 49, 428, DateTimeKind.Local).AddTicks(9623),
                            Title = "Fantastic Frozen Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 842.480734222792m,
                            ReleaseDate = new DateTime(2023, 3, 29, 22, 16, 53, 570, DateTimeKind.Local).AddTicks(6769),
                            Title = "Generic Steel Ball"
                        },
                        new
                        {
                            Id = 12,
                            Barcode = "1",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 928.928430071533m,
                            ReleaseDate = new DateTime(2023, 4, 7, 2, 48, 50, 344, DateTimeKind.Local).AddTicks(5458),
                            Title = "Ergonomic Rubber Car"
                        },
                        new
                        {
                            Id = 13,
                            Barcode = "6",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 706.948686653259m,
                            ReleaseDate = new DateTime(2023, 3, 7, 8, 2, 19, 264, DateTimeKind.Local).AddTicks(1421),
                            Title = "Generic Steel Pizza"
                        },
                        new
                        {
                            Id = 14,
                            Barcode = "3",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 306.262494314584m,
                            ReleaseDate = new DateTime(2022, 8, 31, 21, 14, 57, 751, DateTimeKind.Local).AddTicks(7713),
                            Title = "Small Metal Sausages"
                        },
                        new
                        {
                            Id = 15,
                            Barcode = "2",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 378.222576259273m,
                            ReleaseDate = new DateTime(2023, 3, 22, 14, 20, 50, 781, DateTimeKind.Local).AddTicks(4867),
                            Title = "Fantastic Soft Pants"
                        },
                        new
                        {
                            Id = 16,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 461.718092748764m,
                            ReleaseDate = new DateTime(2022, 7, 10, 6, 15, 39, 248, DateTimeKind.Local).AddTicks(3708),
                            Title = "Gorgeous Frozen Towels"
                        },
                        new
                        {
                            Id = 17,
                            Barcode = "7",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 126.128098112125m,
                            ReleaseDate = new DateTime(2023, 2, 16, 20, 37, 10, 826, DateTimeKind.Local).AddTicks(3177),
                            Title = "Tasty Steel Cheese"
                        },
                        new
                        {
                            Id = 18,
                            Barcode = "8",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 530.970371435383m,
                            ReleaseDate = new DateTime(2023, 2, 13, 22, 19, 52, 185, DateTimeKind.Local).AddTicks(6213),
                            Title = "Gorgeous Granite Cheese"
                        },
                        new
                        {
                            Id = 19,
                            Barcode = "9",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 913.003066283186m,
                            ReleaseDate = new DateTime(2022, 7, 10, 9, 37, 51, 764, DateTimeKind.Local).AddTicks(9544),
                            Title = "Sleek Rubber Chicken"
                        },
                        new
                        {
                            Id = 20,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 940.814879371698m,
                            ReleaseDate = new DateTime(2022, 12, 1, 11, 8, 36, 247, DateTimeKind.Local).AddTicks(2768),
                            Title = "Intelligent Wooden Salad"
                        },
                        new
                        {
                            Id = 21,
                            Barcode = "4",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 479.41424090062m,
                            ReleaseDate = new DateTime(2023, 2, 8, 22, 31, 30, 435, DateTimeKind.Local).AddTicks(5129),
                            Title = "Handcrafted Wooden Sausages"
                        },
                        new
                        {
                            Id = 22,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 320.499838554068m,
                            ReleaseDate = new DateTime(2022, 9, 21, 17, 58, 52, 705, DateTimeKind.Local).AddTicks(2857),
                            Title = "Sleek Granite Car"
                        },
                        new
                        {
                            Id = 23,
                            Barcode = "6",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 478.915239043029m,
                            ReleaseDate = new DateTime(2023, 1, 21, 11, 49, 0, 23, DateTimeKind.Local).AddTicks(6404),
                            Title = "Small Wooden Car"
                        },
                        new
                        {
                            Id = 24,
                            Barcode = "2",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 910.785444308438m,
                            ReleaseDate = new DateTime(2023, 2, 22, 4, 25, 19, 252, DateTimeKind.Local).AddTicks(9557),
                            Title = "Sleek Steel Shirt"
                        },
                        new
                        {
                            Id = 25,
                            Barcode = "3",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 802.238750720974m,
                            ReleaseDate = new DateTime(2023, 3, 10, 5, 54, 10, 816, DateTimeKind.Local).AddTicks(5990),
                            Title = "Incredible Frozen Mouse"
                        },
                        new
                        {
                            Id = 26,
                            Barcode = "7",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 150.818741621831m,
                            ReleaseDate = new DateTime(2023, 1, 2, 23, 30, 30, 940, DateTimeKind.Local).AddTicks(1240),
                            Title = "Incredible Wooden Chair"
                        },
                        new
                        {
                            Id = 27,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 721.773541800572m,
                            ReleaseDate = new DateTime(2022, 9, 24, 11, 34, 6, 936, DateTimeKind.Local).AddTicks(2795),
                            Title = "Gorgeous Plastic Chips"
                        },
                        new
                        {
                            Id = 28,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 688.245783060904m,
                            ReleaseDate = new DateTime(2022, 12, 17, 14, 0, 2, 47, DateTimeKind.Local).AddTicks(8035),
                            Title = "Incredible Fresh Bacon"
                        },
                        new
                        {
                            Id = 29,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 553.558320945389m,
                            ReleaseDate = new DateTime(2023, 3, 12, 0, 30, 56, 40, DateTimeKind.Local).AddTicks(9328),
                            Title = "Incredible Soft Computer"
                        },
                        new
                        {
                            Id = 30,
                            Barcode = "4",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 663.536718269594m,
                            ReleaseDate = new DateTime(2022, 7, 7, 1, 26, 19, 257, DateTimeKind.Local).AddTicks(1098),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 31,
                            Barcode = "2",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 922.479030014704m,
                            ReleaseDate = new DateTime(2023, 6, 1, 23, 52, 8, 453, DateTimeKind.Local).AddTicks(9239),
                            Title = "Handcrafted Concrete Tuna"
                        },
                        new
                        {
                            Id = 32,
                            Barcode = "3",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 255.49067058018m,
                            ReleaseDate = new DateTime(2023, 3, 12, 19, 39, 34, 392, DateTimeKind.Local).AddTicks(9655),
                            Title = "Gorgeous Wooden Fish"
                        },
                        new
                        {
                            Id = 33,
                            Barcode = "7",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 955.272407213818m,
                            ReleaseDate = new DateTime(2022, 12, 18, 20, 8, 35, 643, DateTimeKind.Local).AddTicks(5522),
                            Title = "Handcrafted Frozen Keyboard"
                        },
                        new
                        {
                            Id = 34,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 151.982358236323m,
                            ReleaseDate = new DateTime(2022, 7, 17, 13, 24, 23, 482, DateTimeKind.Local).AddTicks(3102),
                            Title = "Intelligent Plastic Chair"
                        },
                        new
                        {
                            Id = 35,
                            Barcode = "9",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 434.299358334532m,
                            ReleaseDate = new DateTime(2022, 8, 4, 18, 16, 41, 477, DateTimeKind.Local).AddTicks(2788),
                            Title = "Unbranded Wooden Pizza"
                        },
                        new
                        {
                            Id = 36,
                            Barcode = "4",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 57.7988712865854m,
                            ReleaseDate = new DateTime(2022, 8, 24, 12, 50, 39, 10, DateTimeKind.Local).AddTicks(4570),
                            Title = "Gorgeous Rubber Bacon"
                        },
                        new
                        {
                            Id = 37,
                            Barcode = "7",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 883.980300599234m,
                            ReleaseDate = new DateTime(2022, 11, 20, 4, 23, 52, 406, DateTimeKind.Local).AddTicks(2715),
                            Title = "Handcrafted Rubber Shirt"
                        },
                        new
                        {
                            Id = 38,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 822.452619476455m,
                            ReleaseDate = new DateTime(2022, 9, 1, 2, 25, 32, 725, DateTimeKind.Local).AddTicks(4074),
                            Title = "Rustic Granite Shoes"
                        },
                        new
                        {
                            Id = 39,
                            Barcode = "7",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 22.2432652671092m,
                            ReleaseDate = new DateTime(2022, 11, 26, 10, 3, 47, 284, DateTimeKind.Local).AddTicks(9206),
                            Title = "Sleek Granite Chair"
                        },
                        new
                        {
                            Id = 40,
                            Barcode = "2",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 158.364214679396m,
                            ReleaseDate = new DateTime(2023, 2, 13, 6, 50, 3, 908, DateTimeKind.Local).AddTicks(6957),
                            Title = "Incredible Rubber Soap"
                        },
                        new
                        {
                            Id = 41,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 533.504530191656m,
                            ReleaseDate = new DateTime(2023, 3, 28, 13, 55, 26, 56, DateTimeKind.Local).AddTicks(9014),
                            Title = "Awesome Soft Fish"
                        },
                        new
                        {
                            Id = 42,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 265.709933652407m,
                            ReleaseDate = new DateTime(2023, 3, 20, 1, 6, 25, 486, DateTimeKind.Local).AddTicks(4310),
                            Title = "Intelligent Cotton Tuna"
                        },
                        new
                        {
                            Id = 43,
                            Barcode = "2",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 294.402654204239m,
                            ReleaseDate = new DateTime(2022, 9, 11, 16, 52, 39, 42, DateTimeKind.Local).AddTicks(3273),
                            Title = "Refined Soft Bike"
                        },
                        new
                        {
                            Id = 44,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 741.648888164036m,
                            ReleaseDate = new DateTime(2022, 9, 15, 14, 33, 4, 201, DateTimeKind.Local).AddTicks(887),
                            Title = "Handmade Cotton Bacon"
                        },
                        new
                        {
                            Id = 45,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 825.239833488706m,
                            ReleaseDate = new DateTime(2022, 8, 24, 10, 39, 27, 271, DateTimeKind.Local).AddTicks(2392),
                            Title = "Small Soft Tuna"
                        },
                        new
                        {
                            Id = 46,
                            Barcode = "1",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 305.894089151124m,
                            ReleaseDate = new DateTime(2022, 12, 27, 15, 21, 38, 830, DateTimeKind.Local).AddTicks(5886),
                            Title = "Practical Frozen Computer"
                        },
                        new
                        {
                            Id = 47,
                            Barcode = "4",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 778.911179241683m,
                            ReleaseDate = new DateTime(2022, 9, 1, 10, 21, 13, 132, DateTimeKind.Local).AddTicks(9013),
                            Title = "Rustic Wooden Mouse"
                        },
                        new
                        {
                            Id = 48,
                            Barcode = "2",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 318.709401070936m,
                            ReleaseDate = new DateTime(2022, 10, 14, 7, 13, 30, 558, DateTimeKind.Local).AddTicks(8660),
                            Title = "Handcrafted Metal Mouse"
                        },
                        new
                        {
                            Id = 49,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 463.195345650052m,
                            ReleaseDate = new DateTime(2022, 11, 27, 11, 55, 34, 160, DateTimeKind.Local).AddTicks(7853),
                            Title = "Handcrafted Rubber Salad"
                        },
                        new
                        {
                            Id = 50,
                            Barcode = "6",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 717.609017980569m,
                            ReleaseDate = new DateTime(2023, 4, 16, 1, 4, 33, 340, DateTimeKind.Local).AddTicks(6518),
                            Title = "Incredible Plastic Shoes"
                        });
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductDetails", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Manufactuer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductSuppliers", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "SupplierId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ProductSuppliers");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContantEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductDetails", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Product", "Product")
                        .WithOne("ProductDetails")
                        .HasForeignKey("P06Shop.Shared.Shop.ProductDetails", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.ProductSuppliers", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Product", "Product")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P06Shop.Shared.Shop.Supplier", "Supplier")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.Navigation("ProductDetails");

                    b.Navigation("ProductSuppliers");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Supplier", b =>
                {
                    b.Navigation("ProductSuppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
