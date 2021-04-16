﻿// <auto-generated />
using System;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab2API.Migrations
{
    [DbContext(typeof(TraineeDbContext))]
    [Migration("20210415235802_FristCreation")]
    partial class FristCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model_Libraries.Track", b =>
                {
                    b.Property<int>("Track_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Track_ID");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Model_Libraries.Trainee", b =>
                {
                    b.Property<int>("Trainee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("IsGraduated")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Track_ID")
                        .HasColumnType("int");

                    b.HasKey("Trainee_ID");

                    b.HasIndex("Track_ID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Model_Libraries.Trainee", b =>
                {
                    b.HasOne("Model_Libraries.Track", "Track")
                        .WithMany()
                        .HasForeignKey("Track_ID");

                    b.Navigation("Track");
                });
#pragma warning restore 612, 618
        }
    }
}
