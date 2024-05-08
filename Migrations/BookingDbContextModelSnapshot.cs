﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using booking.Data;

#nullable disable

namespace booking.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("booking.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("RentalCompany")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("booking.Models.CreditCard", b =>
                {
                    b.Property<int>("CreditCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExpiryDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("CreditCardId");

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("booking.Models.CreditCardFlight", b =>
                {
                    b.Property<int>("CreditCardFlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Airline")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ArrivalAirport")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DepartureAirport")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExpiryDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("CreditCardFlightId");

                    b.ToTable("CreditCardFlight");
                });

            modelBuilder.Entity("booking.Models.CreditCardHotel", b =>
                {
                    b.Property<int>("CreditCardHotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExpiryDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("CreditCardHotelId");

                    b.ToTable("CreditCardHotel");
                });

            modelBuilder.Entity("booking.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Airline")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ArrivalAirport")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DepartureAirport")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("FlightId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("booking.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("booking.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmergencyContactNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
