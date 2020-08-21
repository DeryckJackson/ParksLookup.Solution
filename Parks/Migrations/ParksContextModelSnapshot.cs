﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

namespace Parks.Migrations
{
    [DbContext(typeof(ParksContext))]
    partial class ParksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Parks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("HasCamping");

                    b.Property<bool>("HasVisitorCenter");

                    b.Property<string>("Hours")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("OpenForSeason");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Zipcode")
                        .IsRequired();

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Address = "NF-4200",
                            City = "Granite Falls",
                            HasCamping = false,
                            HasVisitorCenter = false,
                            Hours = "24hrs",
                            Name = "Mount PilChuck State Park",
                            OpenForSeason = true,
                            State = "WA",
                            Zipcode = "98252"
                        },
                        new
                        {
                            ParkId = 2,
                            Address = "14503 Wallace Lake Road",
                            City = "Gold Bar",
                            HasCamping = true,
                            HasVisitorCenter = false,
                            Hours = "8am - Dusk",
                            Name = "Wallace Falls State Park",
                            OpenForSeason = true,
                            State = "WA",
                            Zipcode = "98251"
                        },
                        new
                        {
                            ParkId = 3,
                            Address = "38730 Cape Horn Road",
                            City = "Concrete",
                            HasCamping = true,
                            HasVisitorCenter = true,
                            Hours = "8am - Dusk",
                            Name = "Rasar State Park",
                            OpenForSeason = true,
                            State = "WA",
                            Zipcode = "98237"
                        },
                        new
                        {
                            ParkId = 4,
                            Address = "Rim Dr",
                            City = "Crater Lake",
                            HasCamping = true,
                            HasVisitorCenter = true,
                            Hours = "24hrs",
                            Name = "Crater Lake National Park",
                            OpenForSeason = true,
                            State = "OR",
                            Zipcode = "97604"
                        },
                        new
                        {
                            ParkId = 5,
                            Address = "6554 Park Blvd",
                            City = "Joshua Tree",
                            HasCamping = true,
                            HasVisitorCenter = true,
                            Hours = "24hrs",
                            Name = "Joshua Tree National Park",
                            OpenForSeason = true,
                            State = "CA",
                            Zipcode = "92252"
                        },
                        new
                        {
                            ParkId = 6,
                            Address = "47050 Generals Highway",
                            City = "Three Rivers",
                            HasCamping = true,
                            HasVisitorCenter = true,
                            Hours = "24hrs",
                            Name = "Sequoia National Park",
                            OpenForSeason = true,
                            State = "CA",
                            Zipcode = "93271"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
