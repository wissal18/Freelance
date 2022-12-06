﻿// <auto-generated />
using System;
using Freelance_Platform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Freelance_Platform.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20221206182424_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Freelance_Platform.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Freelancer", b =>
                {
                    b.Property<int>("FreelancerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricePerHour")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FreelancerID");

                    b.ToTable("Freelancers");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Freelancers_Talents", b =>
                {
                    b.Property<int>("FreelancerID")
                        .HasColumnType("int");

                    b.Property<int>("TalentID")
                        .HasColumnType("int");

                    b.HasKey("FreelancerID", "TalentID");

                    b.HasIndex("TalentID");

                    b.ToTable("Freelancers_Talents");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedDuration")
                        .HasColumnType("int");

                    b.Property<string>("ExperienceLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.HasIndex("ClientID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Projects_Talents", b =>
                {
                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("TalentID")
                        .HasColumnType("int");

                    b.HasKey("ProjectID", "TalentID");

                    b.HasIndex("TalentID");

                    b.ToTable("Projects_Talents");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Talent", b =>
                {
                    b.Property<int>("TalentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TalentID");

                    b.ToTable("Talents");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Freelancers_Talents", b =>
                {
                    b.HasOne("Freelance_Platform.Models.Freelancer", "Freelancer")
                        .WithMany("Freelancers_Talents")
                        .HasForeignKey("FreelancerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Freelance_Platform.Models.Talent", "Talent")
                        .WithMany("Freelancers_Talents")
                        .HasForeignKey("TalentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Freelancer");

                    b.Navigation("Talent");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Project", b =>
                {
                    b.HasOne("Freelance_Platform.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Projects_Talents", b =>
                {
                    b.HasOne("Freelance_Platform.Models.Project", "Project")
                        .WithMany("Projects_Talents")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Freelance_Platform.Models.Talent", "Talent")
                        .WithMany("Projects_Talents")
                        .HasForeignKey("TalentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Talent");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Freelancer", b =>
                {
                    b.Navigation("Freelancers_Talents");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Project", b =>
                {
                    b.Navigation("Projects_Talents");
                });

            modelBuilder.Entity("Freelance_Platform.Models.Talent", b =>
                {
                    b.Navigation("Freelancers_Talents");

                    b.Navigation("Projects_Talents");
                });
#pragma warning restore 612, 618
        }
    }
}
