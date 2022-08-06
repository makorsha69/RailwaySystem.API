﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RailwaySystem.API.Data;

namespace RailwaySystem.API.Migrations
{
    [DbContext(typeof(TrainDbContext))]
    [Migration("20220806092744_BookingGet")]
    partial class BookingGet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RailwaySystem.API.Model.BankCred", b =>
                {
                    b.Property<int>("BankCredId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("BankCredId");

                    b.HasIndex("UserId");

                    b.ToTable("bankCred");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int?>("QuotaId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNum")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("fare")
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("BookingId");

                    b.HasIndex("QuotaId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengerId");

                    b.ToTable("passenger");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Quota", b =>
                {
                    b.Property<int>("QuotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("type")
                        .HasColumnType("varchar(50)");

                    b.HasKey("QuotaId");

                    b.ToTable("quotas");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstAC")
                        .HasColumnType("int");

                    b.Property<int>("SecondAC")
                        .HasColumnType("int");

                    b.Property<int>("Sleeper")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.HasIndex("TrainId");

                    b.ToTable("seat");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Tickets", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TransId")
                        .HasColumnType("int");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("TicketId");

                    b.HasIndex("TransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Train", b =>
                {
                    b.Property<int>("TrainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArrivalStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<double>("distance")
                        .HasColumnType("float");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("TrainId");

                    b.ToTable("trains");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fare")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("TransactionStatus")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("TransactionId");

                    b.HasIndex("BookingId");

                    b.ToTable("transaction");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Role")
                        .HasColumnType("varchar(15)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.BankCred", b =>
                {
                    b.HasOne("RailwaySystem.API.Model.User", null)
                        .WithMany("bankCreds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Booking", b =>
                {
                    b.HasOne("RailwaySystem.API.Model.Quota", null)
                        .WithMany("_booking")
                        .HasForeignKey("QuotaId");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Seat", b =>
                {
                    b.HasOne("RailwaySystem.API.Model.Train", null)
                        .WithMany("seats")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Tickets", b =>
                {
                    b.HasOne("RailwaySystem.API.Model.Transaction", null)
                        .WithMany("tickets")
                        .HasForeignKey("TransactionId");

                    b.HasOne("RailwaySystem.API.Model.User", null)
                        .WithMany("tickets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Transaction", b =>
                {
                    b.HasOne("RailwaySystem.API.Model.Booking", null)
                        .WithMany("transactions")
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Booking", b =>
                {
                    b.Navigation("transactions");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Quota", b =>
                {
                    b.Navigation("_booking");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Train", b =>
                {
                    b.Navigation("seats");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.Transaction", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("RailwaySystem.API.Model.User", b =>
                {
                    b.Navigation("bankCreds");

                    b.Navigation("tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
