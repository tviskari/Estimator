﻿// <auto-generated />
using System;
using Estimator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estimator.Migrations
{
    [DbContext(typeof(EstimatorContext))]
    [Migration("20181107073857_AddDataStructureFix")]
    partial class AddDataStructureFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estimator.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("FeatureId");

                    b.Property<string>("Name");

                    b.Property<double>("QuestimatedHours");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Estimator.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("QuestimatedHours");

                    b.Property<int?>("StoryId");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Estimator.Models.ProjectEstimation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ProjectEstimations");
                });

            modelBuilder.Entity("Estimator.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("ProjectEstimationId");

                    b.Property<double>("QuestimatedHours");

                    b.HasKey("Id");

                    b.HasIndex("ProjectEstimationId");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("Estimator.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("ProjectEstimationId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectEstimationId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Estimator.Models.Component", b =>
                {
                    b.HasOne("Estimator.Models.Feature")
                        .WithMany("Components")
                        .HasForeignKey("FeatureId");
                });

            modelBuilder.Entity("Estimator.Models.Feature", b =>
                {
                    b.HasOne("Estimator.Models.Story")
                        .WithMany("Features")
                        .HasForeignKey("StoryId");
                });

            modelBuilder.Entity("Estimator.Models.ProjectEstimation", b =>
                {
                    b.HasOne("Estimator.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Estimator.Models.Story", b =>
                {
                    b.HasOne("Estimator.Models.ProjectEstimation")
                        .WithMany("Stories")
                        .HasForeignKey("ProjectEstimationId");
                });

            modelBuilder.Entity("Estimator.Models.User", b =>
                {
                    b.HasOne("Estimator.Models.ProjectEstimation")
                        .WithMany("Readers")
                        .HasForeignKey("ProjectEstimationId");
                });
#pragma warning restore 612, 618
        }
    }
}