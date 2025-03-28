﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopService.Infrastructure.Data;

#nullable disable

namespace ShopService.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250315223359_SeedDataFix")]
    partial class SeedDataFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopService.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"),
                            CustomerId = new Guid("4a516000-ff9d-4e6f-97b5-25f1cf5d675b"),
                            OrderDate = new DateTime(2025, 3, 15, 22, 33, 58, 941, DateTimeKind.Utc).AddTicks(337),
                            TotalPrice = 25000.0
                        },
                        new
                        {
                            Id = new Guid("c3d515c6-4826-4965-811c-4042301460ea"),
                            CustomerId = new Guid("c7231e28-8144-4451-b0d2-24a8b957c91d"),
                            OrderDate = new DateTime(2025, 3, 15, 22, 33, 58, 941, DateTimeKind.Utc).AddTicks(688),
                            TotalPrice = 43000.0
                        });
                });

            modelBuilder.Entity("ShopService.Domain.Entities.OrderProducts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bec3964d-a23c-41c2-9e49-1c3877299da0"),
                            OrderId = new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"),
                            ProductId = new Guid("906d2c38-92be-4d31-a900-d5e72cfbff76"),
                            Quantity = 1
                        },
                        new
                        {
                            Id = new Guid("a8d0f2ef-b6a0-41e3-a843-73fcebd784d9"),
                            OrderId = new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"),
                            ProductId = new Guid("d100d97d-db37-4b64-9e17-686dcbe335c7"),
                            Quantity = 1
                        },
                        new
                        {
                            Id = new Guid("e73f76ec-a64f-43e2-8b6e-abac7790000d"),
                            OrderId = new Guid("c3d515c6-4826-4965-811c-4042301460ea"),
                            ProductId = new Guid("969e9845-9cb4-4f18-9f87-aaa287a26028"),
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("ShopService.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Article")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("906d2c38-92be-4d31-a900-d5e72cfbff76"),
                            Article = "ASUS-1234",
                            Category = "Електроніка",
                            Name = "Ноутбук ASUS",
                            Price = 25000.0
                        },
                        new
                        {
                            Id = new Guid("969e9845-9cb4-4f18-9f87-aaa287a26028"),
                            Article = "SAMS-5678",
                            Category = "Електроніка",
                            Name = "Смартфон Samsung",
                            Price = 18000.0
                        },
                        new
                        {
                            Id = new Guid("d100d97d-db37-4b64-9e17-686dcbe335c7"),
                            Article = "LG-91011",
                            Category = "Техніка для дому",
                            Name = "Мікрохвильова піч LG",
                            Price = 7000.0
                        });
                });

            modelBuilder.Entity("ShopService.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a516000-ff9d-4e6f-97b5-25f1cf5d675b"),
                            CreatedAt = new DateTime(2025, 3, 15, 22, 33, 58, 940, DateTimeKind.Utc).AddTicks(4447),
                            DateOfBirth = new DateOnly(1990, 5, 15),
                            FullName = "Петренко Петро Петрович"
                        },
                        new
                        {
                            Id = new Guid("c7231e28-8144-4451-b0d2-24a8b957c91d"),
                            CreatedAt = new DateTime(2025, 3, 15, 22, 33, 58, 940, DateTimeKind.Utc).AddTicks(4574),
                            DateOfBirth = new DateOnly(1985, 10, 20),
                            FullName = "Іваненко Іван Іванович"
                        });
                });

            modelBuilder.Entity("ShopService.Domain.Entities.Order", b =>
                {
                    b.HasOne("ShopService.Domain.Entities.User", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShopService.Domain.Entities.OrderProducts", b =>
                {
                    b.HasOne("ShopService.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopService.Domain.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopService.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ShopService.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ShopService.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
