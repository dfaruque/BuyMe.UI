﻿// <auto-generated />
using System;
using BuyMe.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuyMe.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "3d4d68d6-ee68-488d-af48-c374783d1bc2",
                            Email = "Admin@buyMe.com",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@BUYME.COM",
                            NormalizedUserName = "ADMIN@BUYME.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOxL3HLCiK+AlXLNv5R8G0HAQ4F0uD+/h2s/eobXvWR1SBiB4uFE7bpeB2YGdaqZzg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "25b6cf5a-9475-4e12-a363-087575fd6b64",
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
                            Id = "296512bf-f15a-4499-bad6-1ef1a6cc1418",
                            ConcurrencyStamp = "178d75a8-83c0-4e3e-bf33-9f0214e4477b",
                            Name = "Product",
                            NormalizedName = "Product"
                        },
                        new
                        {
                            Id = "d4ff0382-9320-4565-bb25-25cd8f7e72a0",
                            ConcurrencyStamp = "79a9a369-2938-4d97-8323-7d5ce1f41c63",
                            Name = "Warehouse",
                            NormalizedName = "Warehouse"
                        },
                        new
                        {
                            Id = "b7a767bb-4103-4824-b54c-ceb2a8ce97fa",
                            ConcurrencyStamp = "eb27dbbc-f7ae-404d-b5b5-777e2121a484",
                            Name = "CustomerType",
                            NormalizedName = "CustomerType"
                        },
                        new
                        {
                            Id = "016c3ff2-2ed6-4df2-a3bc-b4892c4c4b97",
                            ConcurrencyStamp = "e76401b2-78b9-4bcb-9886-4512efda9449",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "580d0db4-b0d2-408d-983e-0d6fbd1999f1",
                            ConcurrencyStamp = "d9613360-3f49-4b7c-99f4-19048e5816fd",
                            Name = "SalesType",
                            NormalizedName = "SalesType"
                        },
                        new
                        {
                            Id = "de0216fe-8441-4f1a-b981-b8077ca48478",
                            ConcurrencyStamp = "8a13813a-611a-414d-b6d6-e0e99c9beaec",
                            Name = "SalesOrder",
                            NormalizedName = "SalesOrder"
                        },
                        new
                        {
                            Id = "967502cc-b272-4c76-ba79-a0e7e555b145",
                            ConcurrencyStamp = "364109d2-8506-4d02-b11b-906dbfdcce06",
                            Name = "Category",
                            NormalizedName = "Category"
                        },
                        new
                        {
                            Id = "d6368780-1374-48c9-be39-3eedebef0d43",
                            ConcurrencyStamp = "e40cadc6-a0f1-4b49-8a48-fd43b42cfafa",
                            Name = "UnitOfMeasure",
                            NormalizedName = "UnitOfMeasure"
                        },
                        new
                        {
                            Id = "b8fc7e36-db55-4be5-acdd-8a3cdc03373c",
                            ConcurrencyStamp = "9b9a7909-07b7-4064-ab54-4b548c896f4b",
                            Name = "Currency",
                            NormalizedName = "Currency"
                        },
                        new
                        {
                            Id = "a2233469-9a4e-4dbc-89c8-2301e0f02c4c",
                            ConcurrencyStamp = "a199ca11-1ad8-4c1e-81ac-9be309d5af29",
                            Name = "Branch",
                            NormalizedName = "Branch"
                        },
                        new
                        {
                            Id = "ec477481-5fa5-4b6a-9be2-323246d2fbd6",
                            ConcurrencyStamp = "c1ca34ca-5fc4-4b71-9cd7-76922282fac6",
                            Name = "Template",
                            NormalizedName = "Template"
                        },
                        new
                        {
                            Id = "c31a9c08-20cf-4bdf-b4e0-f304ce6ac1fa",
                            ConcurrencyStamp = "42588133-09fb-450d-91c4-9b5fcb46d005",
                            Name = "Settings",
                            NormalizedName = "Settings"
                        },
                        new
                        {
                            Id = "f0e4e0ac-7e8e-4e34-b174-17361c80f015",
                            ConcurrencyStamp = "0e921946-72a2-4ab5-bd47-6818643beb36",
                            Name = "User",
                            NormalizedName = "User"
                        },
                        new
                        {
                            Id = "2eb006d7-c828-483e-a5f6-3c45c33ce653",
                            ConcurrencyStamp = "6177adfe-48fa-49fb-b4c9-396fa2ff5b31",
                            Name = "ChangeRole",
                            NormalizedName = "ChangeRole"
                        },
                        new
                        {
                            Id = "87b70e94-598b-4844-97c8-117677b54d5e",
                            ConcurrencyStamp = "320eb04a-2baa-4165-b976-fa5b7e9a6978",
                            Name = "ShipmentType",
                            NormalizedName = "ShipmentType"
                        },
                        new
                        {
                            Id = "c38da81b-231b-4a17-85d7-532c788bc610",
                            ConcurrencyStamp = "e5cf780f-fd24-469f-ab54-9196599df9f9",
                            Name = "Shipment",
                            NormalizedName = "Shipment"
                        },
                        new
                        {
                            Id = "6363ea16-8ee3-4e8e-b552-c2fec0e805ee",
                            ConcurrencyStamp = "6932e7d4-26ff-4dbf-9ddf-9a2a719a9047",
                            Name = "InvoiceType",
                            NormalizedName = "InvoiceType"
                        },
                        new
                        {
                            Id = "95c36d81-36b8-4620-9404-7e28dde91525",
                            ConcurrencyStamp = "8db39d72-1458-441b-ade9-c680c67ae079",
                            Name = "Invoice",
                            NormalizedName = "Invoice"
                        },
                        new
                        {
                            Id = "89c02269-dc40-4855-ab44-cab18c948831",
                            ConcurrencyStamp = "8cc734b7-856d-4266-91e3-6f8472454c27",
                            Name = "PaymentType",
                            NormalizedName = "PaymentType"
                        },
                        new
                        {
                            Id = "e9aba7ee-c6fe-43d4-bf5b-9957fde39dc2",
                            ConcurrencyStamp = "b2b555b1-3e49-4686-aba6-d6cc43030a56",
                            Name = "PaymentReceive",
                            NormalizedName = "PaymentReceive"
                        },
                        new
                        {
                            Id = "e5c5026e-7425-42f2-9e76-b9e44510c4b9",
                            ConcurrencyStamp = "8ca3d417-1192-4098-acc7-f71399bbf898",
                            Name = "VendorType",
                            NormalizedName = "VendorType"
                        },
                        new
                        {
                            Id = "8cd89f28-784c-4d56-88f0-f72bad5c2daf",
                            ConcurrencyStamp = "b418e1b1-d57a-49f1-b92e-c82bc913b249",
                            Name = "Vendor",
                            NormalizedName = "Vendor"
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
