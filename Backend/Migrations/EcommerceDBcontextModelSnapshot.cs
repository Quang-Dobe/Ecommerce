﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(EcommerceDBcontext))]
    partial class EcommerceDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("SharedView.Model.Company", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("SharedView.Model.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("SharedView.Model.CustomerAccount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Customerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Customerid");

                    b.ToTable("customerAccounts");
                });

            modelBuilder.Entity("SharedView.Model.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("accountIdid")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("accountIdid");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("SharedView.Model.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("number")
                        .HasColumnType("int")
                        .HasColumnName("Number of product");

                    b.Property<int>("orderIdid")
                        .HasColumnType("int");

                    b.Property<int>("productIdid")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("orderIdid");

                    b.HasIndex("productIdid");

                    b.ToTable("orderDetails");
                });

            modelBuilder.Entity("SharedView.Model.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Companyid")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("inventoryNumber")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Product's name");

                    b.Property<int>("productSiteIdid")
                        .HasColumnType("int");

                    b.Property<int>("productType")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<double>("rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.HasIndex("productSiteIdid");

                    b.ToTable("products");
                });

            modelBuilder.Entity("SharedView.Model.ProductSite", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("companyIdid")
                        .HasColumnType("int");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("companyIdid");

                    b.ToTable("productSites");
                });

            modelBuilder.Entity("SharedView.Model.CustomerAccount", b =>
                {
                    b.HasOne("SharedView.Model.Customer", null)
                        .WithMany("accountId")
                        .HasForeignKey("Customerid");
                });

            modelBuilder.Entity("SharedView.Model.Order", b =>
                {
                    b.HasOne("SharedView.Model.CustomerAccount", "accountId")
                        .WithMany()
                        .HasForeignKey("accountIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("accountId");
                });

            modelBuilder.Entity("SharedView.Model.OrderDetail", b =>
                {
                    b.HasOne("SharedView.Model.Order", "orderId")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedView.Model.Product", "productId")
                        .WithMany()
                        .HasForeignKey("productIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("orderId");

                    b.Navigation("productId");
                });

            modelBuilder.Entity("SharedView.Model.Product", b =>
                {
                    b.HasOne("SharedView.Model.Company", null)
                        .WithMany("products")
                        .HasForeignKey("Companyid");

                    b.HasOne("SharedView.Model.ProductSite", "productSiteId")
                        .WithMany()
                        .HasForeignKey("productSiteIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productSiteId");
                });

            modelBuilder.Entity("SharedView.Model.ProductSite", b =>
                {
                    b.HasOne("SharedView.Model.Company", "companyId")
                        .WithMany()
                        .HasForeignKey("companyIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("companyId");
                });

            modelBuilder.Entity("SharedView.Model.Company", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("SharedView.Model.Customer", b =>
                {
                    b.Navigation("accountId");
                });

            modelBuilder.Entity("SharedView.Model.Order", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
