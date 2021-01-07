﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruckRegistration.Data;

namespace TruckRegistration.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TruckRegistration.Domain.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int>("TruckModelId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("YearManufacturing")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("YearModel")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TruckModelId");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("TruckRegistration.Domain.TruckModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TruckModel");
                });

            modelBuilder.Entity("TruckRegistration.Domain.Truck", b =>
                {
                    b.HasOne("TruckRegistration.Domain.TruckModel", "TruckModel")
                        .WithMany()
                        .HasForeignKey("TruckModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TruckModel");
                });
#pragma warning restore 612, 618
        }
    }
}