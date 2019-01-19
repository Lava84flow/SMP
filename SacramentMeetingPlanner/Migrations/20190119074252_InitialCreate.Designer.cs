﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    [Migration("20190119074252_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bishopric")
                        .IsRequired();

                    b.Property<string>("ClosingPrayer")
                        .IsRequired();

                    b.Property<string>("ClosingSong")
                        .IsRequired();

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("IntermediateSong");

                    b.Property<DateTime>("MeetingDate");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired();

                    b.Property<string>("OpeningSong")
                        .IsRequired();

                    b.Property<string>("SacramentSong")
                        .IsRequired();

                    b.Property<string>("Speaker1")
                        .IsRequired();

                    b.Property<string>("Speaker2")
                        .IsRequired();

                    b.Property<string>("Speaker3");

                    b.Property<string>("Subject1")
                        .IsRequired();

                    b.Property<string>("Subject2");

                    b.Property<string>("Subject3");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}