﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240404111527_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "e45f6f12-894d-4a7a-848f-08b99a66dac4",
                            Description = "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/1/500",
                            Price = 1000L,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = "1dfd92eb-eb2c-4a05-aa27-82bac215a27b",
                            Description = "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/2/500",
                            Price = 2000L,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = "37061a6a-bc1f-466e-b333-ad27c6081fec",
                            Description = "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/3/500",
                            Price = 3000L,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = "ad7bf947-951d-4f7c-aa0d-e4750c2a0235",
                            Description = "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/4/500",
                            Price = 4000L,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = "49c7f262-5793-4ef1-ba11-7ff640dd5606",
                            Description = "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/5/500",
                            Price = 5000L,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = "b2200873-a325-4517-b801-a07731f09264",
                            Description = "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/6/500",
                            Price = 6000L,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = "ed5ed498-0f35-41af-91c8-4e8405f9d7f7",
                            Description = "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/7/500",
                            Price = 7000L,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = "d4b36de2-262a-4a0b-8dee-e6eac5309d47",
                            Description = "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/8/500",
                            Price = 8000L,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = "6c3da1c3-112f-4e64-86f8-7340d344bd8a",
                            Description = "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/9/500",
                            Price = 9000L,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = "a3cc9f56-8c20-4972-9c85-74bd74f38f88",
                            Description = "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/10/500",
                            Price = 10000L,
                            Title = "Product 10"
                        },
                        new
                        {
                            Id = "764c3b61-210f-4df4-ad93-74119cf347ea",
                            Description = "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/11/500",
                            Price = 11000L,
                            Title = "Product 11"
                        },
                        new
                        {
                            Id = "262b56e5-690c-4657-833a-54d2ed73137b",
                            Description = "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/12/500",
                            Price = 12000L,
                            Title = "Product 12"
                        },
                        new
                        {
                            Id = "2dec1732-1a4e-465b-b5b7-0565dd957293",
                            Description = "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/13/500",
                            Price = 13000L,
                            Title = "Product 13"
                        },
                        new
                        {
                            Id = "37608311-2a47-4c25-a37b-b03972642320",
                            Description = "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/14/500",
                            Price = 14000L,
                            Title = "Product 14"
                        },
                        new
                        {
                            Id = "80176f01-43cb-458e-b771-d4ed8c846e06",
                            Description = "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/15/500",
                            Price = 15000L,
                            Title = "Product 15"
                        },
                        new
                        {
                            Id = "f05a2e2c-f39c-4699-b361-ad69c4fe6cea",
                            Description = "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/16/500",
                            Price = 16000L,
                            Title = "Product 16"
                        },
                        new
                        {
                            Id = "e072e012-349c-49d8-861b-5eefd8816af3",
                            Description = "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/17/500",
                            Price = 17000L,
                            Title = "Product 17"
                        },
                        new
                        {
                            Id = "28420ca1-1c20-47ac-a11c-0ca7a9600daa",
                            Description = "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/18/500",
                            Price = 18000L,
                            Title = "Product 18"
                        },
                        new
                        {
                            Id = "b8fbc19f-b24b-445d-ab79-ae421908e92a",
                            Description = "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/19/500",
                            Price = 19000L,
                            Title = "Product 19"
                        },
                        new
                        {
                            Id = "0adeb68b-a7ba-469c-a87f-dc2c308dec59",
                            Description = "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.",
                            ImageUrl = "https://picsum.photos/id/20/500",
                            Price = 20000L,
                            Title = "Product 20"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}