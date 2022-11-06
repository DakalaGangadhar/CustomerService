﻿// <auto-generated />
using System;
using Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Common.Migrations
{
    [DbContext(typeof(customerserviceDBContext))]
    [Migration("20221106085529_ServiceRequestStatudata")]
    partial class ServiceRequestStatudata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Models.Country", b =>
                {
                    b.Property<int>("cId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("countryname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("cId");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("Common.Models.District", b =>
                {
                    b.Property<int>("districtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("districtname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("stateId")
                        .HasColumnType("int");

                    b.HasKey("districtId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Common.Models.Registration", b =>
                {
                    b.Property<int>("registrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("cId")
                        .HasColumnType("int");

                    b.Property<string>("contactnumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("customername")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("districtId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("pancard")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("registrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("stateId")
                        .HasColumnType("int");

                    b.HasKey("registrationId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Common.Models.ServiceRequest", b =>
                {
                    b.Property<int>("srId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("assignId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createrequestdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("registrationId")
                        .HasColumnType("int");

                    b.Property<int>("srcId")
                        .HasColumnType("int");

                    b.Property<int>("statusId")
                        .HasColumnType("int");

                    b.HasKey("srId");

                    b.ToTable("ServiceRequests");
                });

            modelBuilder.Entity("Common.Models.ServiceRequestAssign", b =>
                {
                    b.Property<int>("assignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("assignname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("srcId")
                        .HasColumnType("int");

                    b.HasKey("assignId");

                    b.ToTable("ServiceRequestAssigns");
                });

            modelBuilder.Entity("Common.Models.ServiceRequestCategorie", b =>
                {
                    b.Property<int>("srcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("srcId");

                    b.ToTable("ServiceRequestCategories");
                });

            modelBuilder.Entity("Common.Models.ServiceRequestStatu", b =>
                {
                    b.Property<int>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("statusname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("statusId");

                    b.ToTable("ServiceRequestStatus");
                });

            modelBuilder.Entity("Common.Models.State", b =>
                {
                    b.Property<int>("stateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cId")
                        .HasColumnType("int");

                    b.Property<string>("statename")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("stateId");

                    b.ToTable("States");
                });
#pragma warning restore 612, 618
        }
    }
}