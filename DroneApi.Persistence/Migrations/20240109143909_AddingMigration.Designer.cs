﻿// <auto-generated />
using System;
using DroneApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DroneApi.Persistence.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240109143909_AddingMigration")]
    partial class AddingMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DroneApi.Core.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OrderId");

                    b.Property<string>("BusinessLocation")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("DropoffLocation")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("SubmitedOrders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c3d4c053-49b6-410c-bc78-2d54a9991870"),
                            BusinessLocation = "Villa Mella-Sector14",
                            DropoffLocation = "dropoff-station-4"
                        });
                });

            modelBuilder.Entity("DroneApi.Core.Entities.TestModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("TestModels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("dcbb9c1f-8fb7-49b5-b60a-a09c5197a97c"),
                            Name = "test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}