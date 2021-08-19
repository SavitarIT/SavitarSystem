﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Savitar.Infrastructure.Repository.EFCore;

namespace Savitar.Infrastructure.Repository.EFCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210805223819_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Savitar.Domain.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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
                });

            modelBuilder.Entity("Savitar.Domain.Models.CV.ProjectTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstUse")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUse")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Proficiency")
                        .HasColumnType("int");

                    b.Property<int>("UsageFrequency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name");

                    b.ToTable("ProjectTechnologies");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            FirstUse = new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AS400 Mainframe",
                            Proficiency = 0,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 6,
                            FirstUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Automapper",
                            Proficiency = 3,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            FirstUse = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Blazor Server",
                            Proficiency = 2,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            FirstUse = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Blazor WebAssembly",
                            Proficiency = 2,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 2,
                            FirstUse = new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "C++",
                            Proficiency = 3,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            FirstUse = new DateTime(2001, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "C#",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            FirstUse = new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Delphi",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            FirstUse = new DateTime(2014, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = ".NET Core",
                            Proficiency = 2,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            FirstUse = new DateTime(2001, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = ".NET Framework",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 6,
                            FirstUse = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Excel",
                            Proficiency = 2,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            FirstUse = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Microsoft Access",
                            Proficiency = 2,
                            UsageFrequency = 1
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 6,
                            FirstUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Postman",
                            Proficiency = 2,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            FirstUse = new DateTime(1998, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "SQL Server",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            FirstUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Structure Map",
                            Proficiency = 3,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 2,
                            FirstUse = new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Visual Basic",
                            Proficiency = 2,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 2,
                            FirstUse = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Visual Basic.NET",
                            Proficiency = 2,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            FirstUse = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Visual Studio",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            FirstUse = new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Web Services",
                            Proficiency = 2,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            FirstUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Entity Framework",
                            Proficiency = 3,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            FirstUse = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "PostgreSQL",
                            Proficiency = 0,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            FirstUse = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "nHibernate",
                            Proficiency = 2,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            FirstUse = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Web/REST API",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            FirstUse = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Turbo Pascal",
                            Proficiency = 3,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 2,
                            FirstUse = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Javascript",
                            Proficiency = 3,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 6,
                            FirstUse = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "RabbitMQ",
                            Proficiency = 0,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 2,
                            FirstUse = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Python",
                            Proficiency = 0,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 3,
                            FirstUse = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "VUE",
                            Proficiency = 0,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 1,
                            FirstUse = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "PyCharm",
                            Proficiency = 0,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 1,
                            FirstUse = new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "VS Code",
                            Proficiency = 2,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 6,
                            FirstUse = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "PowerShell",
                            Proficiency = 3,
                            UsageFrequency = 2
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 1,
                            FirstUse = new DateTime(2005, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Borland Developer Studio",
                            Proficiency = 3,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 6,
                            FirstUse = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastUse = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Apache Spark",
                            Proficiency = 0,
                            UsageFrequency = 0
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 6,
                            FirstUse = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Docker",
                            Proficiency = 0,
                            UsageFrequency = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            FirstUse = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = ".NET 5",
                            Proficiency = 2,
                            UsageFrequency = 3
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 6,
                            FirstUse = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MudBlazor",
                            Proficiency = 2,
                            UsageFrequency = 2
                        });
                });

            modelBuilder.Entity("Savitar.Domain.Models.CV.ProjectTechnologyCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("ProjectTechnologyCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IDE"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Language"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Framework"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Database"
                        },
                        new
                        {
                            Id = 5,
                            Name = "ORM"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Tool"
                        });
                });

            modelBuilder.Entity("Savitar.Domain.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Title");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "<p>Specialising in cross platform .NET technologies, I am a full stack dev for hire.</p>\r\n<p>I have been a coder since I was 15 in 1986 and turned professional in 1996. I have been a coder ever since - and won't have it any other way. This passion for what I do ensures you get software written with pride.</p>\r\n<br />\r\n<p>You can purchase my time in a multitude of flexible ways, including...</p>\r\n<ul>\r\n    <li>Per Module</li>\r\n    <li>Per Project</li>    \r\n    <li>Per Hour</li>\r\n    <li>1 or more days per week - 1 or more weeks per month (most common). We agree on the pre-booked time and enter into a retainer. The per hour rate is also reduced relative to the kind of time booked in this arrangment.</li>\r\n</ul>\r\n<br />\r\n<p>Your invoice will come from Savitar IT (VAT registered).</p>",
                            Title = "Software Development Services"
                        },
                        new
                        {
                            Id = 2,
                            Description = "From the ground up, I can build you a new system adhering to the most current standards and specifications.\r\n<br/><br/>\r\nEnterprise systems built on top of open source .NET Core.\r\n                ",
                            Title = "Complete Systems"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Having many years experience in a multitude of languages and frameworks (please see <a href='/skillsmatrix'>Skills Matrix</a>), I can assist with upgrading legacy language/framework systems to more modern languages and frameworks.\r\n<br/><br/>\r\n<b>Use Cases</b>\r\n<ul>\r\n    <li>Angular / React / Vue TO Blazor WebAssembly</li>\r\n    <li>WPF (Windows Presentation Foundation) or Silverlight to Blazor (WebAssembly or Server)</li>    \r\n    <li>.NET Framework TO .NET 5</li>\r\n    <li>C / C++ / Delphi / Visual Basic TO C#</li>\r\n    <li>Desktop application to Web application</li>\r\n</ul>",
                            Title = "Conversions/Upgrades"
                        },
                        new
                        {
                            Id = 4,
                            Description = "I can help your juniors accellerate their learning curves. I love to talk and teach code!",
                            Title = "Mentoring"
                        });
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
                    b.HasOne("Savitar.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Savitar.Domain.Models.ApplicationUser", null)
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

                    b.HasOne("Savitar.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Savitar.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Savitar.Domain.Models.CV.ProjectTechnology", b =>
                {
                    b.HasOne("Savitar.Domain.Models.CV.ProjectTechnologyCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}