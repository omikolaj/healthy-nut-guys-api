﻿// <auto-generated />
using System;
using HealthyNutGuysDataCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthyNutGuysDataCore.Migrations
{
    [DbContext(typeof(HealthyNutGuysContext))]
    partial class HealthyNutGuysContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Cart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Abandoned")
                        .HasColumnType("bit");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.CartItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDetailsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("SavedForLater")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductDetailsId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.CustomProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CustomProducts");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.CustomSelectOption", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Option")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomProductId");

                    b.ToTable("CustomSelectOptions");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Discount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Ingredient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("MixCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MixCategoryId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.MixCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomProductId");

                    b.ToTable("MixCategories");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("DiscountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DiscountId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.OrderItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductDetailsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductDetailsId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.ProductDetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("LabelSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.PromoCode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PromoCodes");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SaleItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal?>("DiscountValue")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PromoCodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("SpecialOfferId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PromoCodeId");

                    b.HasIndex("SpecialOfferId");

                    b.ToTable("SaleItems");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SelectOption", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Option")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDetailsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductDetailsId")
                        .IsUnique()
                        .HasFilter("[ProductDetailsId] IS NOT NULL");

                    b.ToTable("SelectOptions");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SpecialOffer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AppliesNextOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal?>("DiscountValue")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("DisplayMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("PromoCodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Scope")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserSubscriptionId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PromoCodeId");

                    b.HasIndex("UserSubscriptionId");

                    b.ToTable("SpecialOffers");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SubscriptionOffer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("SpecialOfferId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("StandardOffer")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialOfferId");

                    b.ToTable("SubscriptionOffers");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CustomProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.UserSubscription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NextDelivery")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubscriptionOfferId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.HasIndex("SubscriptionOfferId");

                    b.ToTable("UserSubscriptions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Address", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Addresses")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Cart", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Carts")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.CartItem", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("HealthyNutGuysDomain.Models.ProductDetails", "PropductDetails")
                        .WithMany()
                        .HasForeignKey("ProductDetailsId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.CustomProduct", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.CustomSelectOption", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.CustomProduct", "CustomProduct")
                        .WithMany("SelectOptions")
                        .HasForeignKey("CustomProductId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Ingredient", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.MixCategory", "MixCategory")
                        .WithMany("Ingredients")
                        .HasForeignKey("MixCategoryId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.MixCategory", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.CustomProduct", "Product")
                        .WithMany("MixCategories")
                        .HasForeignKey("CustomProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Order", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId");

                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("HealthyNutGuysDomain.Models.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.OrderItem", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.Order", "Order")
                        .WithMany("OrerItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("HealthyNutGuysDomain.Models.ProductDetails", "ProductDetails")
                        .WithMany()
                        .HasForeignKey("ProductDetailsId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Product", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.ProductDetails", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SaleItem", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.CustomProduct", "CustomProduct")
                        .WithMany("Sales")
                        .HasForeignKey("CustomProductId");

                    b.HasOne("HealthyNutGuysDomain.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId");

                    b.HasOne("HealthyNutGuysDomain.Models.PromoCode", "PromoCode")
                        .WithMany()
                        .HasForeignKey("PromoCodeId");

                    b.HasOne("HealthyNutGuysDomain.Models.SpecialOffer", "SpecialOffer")
                        .WithMany()
                        .HasForeignKey("SpecialOfferId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SelectOption", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ProductDetails", "ProductDetails")
                        .WithOne("SelectOption")
                        .HasForeignKey("HealthyNutGuysDomain.Models.SelectOption", "ProductDetailsId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SpecialOffer", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.PromoCode", "PromoCode")
                        .WithMany()
                        .HasForeignKey("PromoCodeId");

                    b.HasOne("HealthyNutGuysDomain.Models.UserSubscription", "UserSubscription")
                        .WithMany("SpecialOffers")
                        .HasForeignKey("UserSubscriptionId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.SubscriptionOffer", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.SpecialOffer", "SpecialOffer")
                        .WithMany()
                        .HasForeignKey("SpecialOfferId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.Tag", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.CustomProduct", null)
                        .WithMany("Tags")
                        .HasForeignKey("CustomProductId");

                    b.HasOne("HealthyNutGuysDomain.Models.Product", null)
                        .WithMany("Tags")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("HealthyNutGuysDomain.Models.UserSubscription", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Subscription")
                        .HasForeignKey("HealthyNutGuysDomain.Models.UserSubscription", "ApplicationUserId");

                    b.HasOne("HealthyNutGuysDomain.Models.SubscriptionOffer", "SubscriptionOffer")
                        .WithMany()
                        .HasForeignKey("SubscriptionOfferId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HealthyNutGuysDomain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
