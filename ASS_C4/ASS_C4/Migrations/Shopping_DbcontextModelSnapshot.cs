﻿// <auto-generated />
using System;
using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASS_C4.Migrations
{
    [DbContext(typeof(Shopping_Dbcontext))]
    partial class Shopping_DbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment.Models.Data.Bill", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("Date");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("Receiveddate")
                        .HasColumnType("Date");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Bill", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.BillDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHD");

                    b.HasIndex("IdSp");

                    b.ToTable("BillDetails", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Capacity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacitys")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ID");

                    b.ToTable("Capacity", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Cart", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("UserID");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.CartDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("IDSp");

                    b.HasIndex("UserID");

                    b.ToTable("CatDetails", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("CapacityID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("SupplierID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CapacityID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Role", b =>
                {
                    b.Property<Guid>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdRole");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Supplier", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptionSupplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("NameSupplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Assignment.Models.Data.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("IDRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("IDRole");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Assignment.Models.Data.Bill", b =>
                {
                    b.HasOne("Assignment.Models.Data.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Assignment.Models.Data.BillDetail", b =>
                {
                    b.HasOne("Assignment.Models.Data.Bill", "Bills")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Data.Product", "Product")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bills");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment.Models.Data.Cart", b =>
                {
                    b.HasOne("Assignment.Models.Data.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Assignment.Models.Data.CartDetails", b =>
                {
                    b.HasOne("Assignment.Models.Data.Product", "Product")
                        .WithMany("CartDetail")
                        .HasForeignKey("IDSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Data.Cart", "Cart")
                        .WithMany("CartDetail")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment.Models.Data.Product", b =>
                {
                    b.HasOne("Assignment.Models.Data.Capacity", "Capacity")
                        .WithMany("Products")
                        .HasForeignKey("CapacityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Data.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Data.Supplier", "Supplier")
                        .WithMany("Product")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Capacity");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Assignment.Models.Data.User", b =>
                {
                    b.HasOne("Assignment.Models.Data.Role", "Roles")
                        .WithMany("User")
                        .HasForeignKey("IDRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Assignment.Models.Data.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Assignment.Models.Data.Capacity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Assignment.Models.Data.Cart", b =>
                {
                    b.Navigation("CartDetail");
                });

            modelBuilder.Entity("Assignment.Models.Data.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Assignment.Models.Data.Product", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetail");
                });

            modelBuilder.Entity("Assignment.Models.Data.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Assignment.Models.Data.Supplier", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment.Models.Data.User", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
