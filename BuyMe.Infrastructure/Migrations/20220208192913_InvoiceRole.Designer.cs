﻿// <auto-generated />
using System;
using BuyMe.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuyMe.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220208192913_InvoiceRole")]
    partial class InvoiceRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuyMe.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc242665-5913-4a62-8802-1d75b34cdc96",
                            Email = "Admin@buyMe.com",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@BUYME.COM",
                            NormalizedUserName = "ADMIN@BUYME.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOyPvkpiRUgAhAK1f9UaIPphuJO3psM7Zsewkq1vSpnpgaQW6U2dRralTik94V3f2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "befd5c69-e1db-437c-9456-3bd4ff54c6ac",
                            TwoFactorEnabled = false,
                            UserName = "Admin@buyMe.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            ConcurrencyStamp = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            Name = "SuperAdmin",
                            NormalizedName = "SuperAdmin"
                        },
                        new
                        {
                            Id = "6077a724-ec4d-4b26-a90c-1fd5c63f4313",
                            ConcurrencyStamp = "3178bf30-fddd-43a2-96d8-8c611b498273",
                            Name = "Product",
                            NormalizedName = "Product"
                        },
                        new
                        {
                            Id = "47db9355-fa30-4d3e-abee-42c3b441514b",
                            ConcurrencyStamp = "f901502a-4745-40ab-ad36-e83121725b2d",
                            Name = "Warehouse",
                            NormalizedName = "Warehouse"
                        },
                        new
                        {
                            Id = "cd5a95ae-ee89-435a-af20-068f6d09c3bc",
                            ConcurrencyStamp = "a237585e-4d18-4741-a56b-406fe3ea55aa",
                            Name = "CustomerType",
                            NormalizedName = "CustomerType"
                        },
                        new
                        {
                            Id = "ed505e8b-409f-4240-88bc-06437b7c7033",
                            ConcurrencyStamp = "05d866ca-36e3-4c06-aed6-bab3a6b1539e",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "76e3e985-2d1f-4ba0-a3d6-3668fef48012",
                            ConcurrencyStamp = "f8670b50-6a09-4e9a-a167-c9f29aef5628",
                            Name = "SalesType",
                            NormalizedName = "SalesType"
                        },
                        new
                        {
                            Id = "0341bc5d-0415-4169-880d-7146717fa037",
                            ConcurrencyStamp = "58af0a53-05e5-4b99-82c5-7349996f23ce",
                            Name = "SalesOrder",
                            NormalizedName = "SalesOrder"
                        },
                        new
                        {
                            Id = "df45e25a-41bc-4dfd-8c62-ad12c60c088f",
                            ConcurrencyStamp = "dd708308-5c3a-4a66-916f-d6e23ae87660",
                            Name = "Category",
                            NormalizedName = "Category"
                        },
                        new
                        {
                            Id = "355cf6c0-2192-47d1-9993-4961d33a63b9",
                            ConcurrencyStamp = "37263905-3161-425e-9f80-800a50cff901",
                            Name = "UnitOfMeasure",
                            NormalizedName = "UnitOfMeasure"
                        },
                        new
                        {
                            Id = "dfd449dc-ec75-4d71-aa38-53ffc9df69be",
                            ConcurrencyStamp = "4b57636a-4c36-4a88-ac52-46f04294183c",
                            Name = "Currency",
                            NormalizedName = "Currency"
                        },
                        new
                        {
                            Id = "c33f072f-f3ba-458d-b80a-3fdebab1b453",
                            ConcurrencyStamp = "88e9924b-2dac-40a7-b757-7d469dd99e9d",
                            Name = "Branch",
                            NormalizedName = "Branch"
                        },
                        new
                        {
                            Id = "18570971-2dac-49ed-9f5b-6b8485a75300",
                            ConcurrencyStamp = "34f77081-e992-459c-9cc4-a0cea750e019",
                            Name = "Template",
                            NormalizedName = "Template"
                        },
                        new
                        {
                            Id = "919a94ee-2cfa-4a1c-93a3-ff1f2d779ef3",
                            ConcurrencyStamp = "6ac21901-c413-4b1b-9cfb-7bbc172d60b9",
                            Name = "Settings",
                            NormalizedName = "Settings"
                        },
                        new
                        {
                            Id = "3c5acd2f-fd43-4c15-bab6-5ebaddaa9453",
                            ConcurrencyStamp = "b3b5a057-d4d1-48af-ae49-026ca2d59dc9",
                            Name = "User",
                            NormalizedName = "User"
                        },
                        new
                        {
                            Id = "84b30b35-1cb4-4c84-9b91-f37a846633b4",
                            ConcurrencyStamp = "4a07f537-cfd8-47f7-82d4-ad137bd0ce72",
                            Name = "ChangeRole",
                            NormalizedName = "ChangeRole"
                        },
                        new
                        {
                            Id = "1bf88724-0b82-409f-856e-6bfc51f4ab35",
                            ConcurrencyStamp = "12b90968-1b40-43a1-9073-3d1d70f37836",
                            Name = "ShipmentType",
                            NormalizedName = "ShipmentType"
                        },
                        new
                        {
                            Id = "cc8e8181-0865-4ed7-8ebe-197d05773389",
                            ConcurrencyStamp = "ca8a5b2d-cf35-47c8-a5df-31082dbc2705",
                            Name = "Shipment",
                            NormalizedName = "Shipment"
                        },
                        new
                        {
                            Id = "74cd768a-f2e3-44a0-a6c1-42d03ff50b05",
                            ConcurrencyStamp = "7ef123b4-aaf9-406a-91ae-e71866aa83db",
                            Name = "InvoiceType",
                            NormalizedName = "InvoiceType"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            RoleId = "341743f0-asd2–42de-afbf-59kmkkmk72cf6"
                        });
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
                    b.HasOne("BuyMe.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BuyMe.Infrastructure.Identity.ApplicationUser", null)
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

                    b.HasOne("BuyMe.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BuyMe.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
