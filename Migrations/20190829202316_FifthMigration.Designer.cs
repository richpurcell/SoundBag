﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoundBag.Models;

namespace SoundBag.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190829202316_FifthMigration")]
    partial class FifthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SoundBag.Models.Association", b =>
                {
                    b.Property<int>("AssociationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttendeeId");

                    b.Property<int>("FestivalId");

                    b.HasKey("AssociationId");

                    b.HasIndex("AttendeeId");

                    b.HasIndex("FestivalId");

                    b.ToTable("associations");
                });

            modelBuilder.Entity("SoundBag.Models.Festival", b =>
                {
                    b.Property<int>("FestivalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("LineupLink");

                    b.Property<int>("OrganizerId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("State");

                    b.Property<string>("TicketLink");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("ZipCode");

                    b.HasKey("FestivalId");

                    b.ToTable("festivals");
                });

            modelBuilder.Entity("SoundBag.Models.Quote", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("created_at");

                    b.Property<string>("name");

                    b.Property<string>("quote");

                    b.Property<string>("updated_at");

                    b.HasKey("id");

                    b.ToTable("quotes");
                });

            modelBuilder.Entity("SoundBag.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SoundBag.Models.Association", b =>
                {
                    b.HasOne("SoundBag.Models.User", "Attendee")
                        .WithMany("Events")
                        .HasForeignKey("AttendeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoundBag.Models.Festival", "Event")
                        .WithMany("Attendees")
                        .HasForeignKey("FestivalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}