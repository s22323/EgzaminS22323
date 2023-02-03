﻿// <auto-generated />
using System;
using EgzaminS22323.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EgzaminS22323.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230203082537_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EgzaminS22323.Models.Project", b =>
                {
                    b.Property<int>("IdTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTeam"), 1L, 1);

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTeam");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EgzaminS22323.Models.Task", b =>
                {
                    b.Property<int>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTask"), 1L, 1);

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ICreatorNavigationIdTeamMember")
                        .HasColumnType("int");

                    b.Property<int>("IdAssignedTo")
                        .HasColumnType("int");

                    b.Property<int>("IdCreator")
                        .HasColumnType("int");

                    b.Property<int>("IdTaskType")
                        .HasColumnType("int");

                    b.Property<int>("IdTeam")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTask");

                    b.HasIndex("ICreatorNavigationIdTeamMember");

                    b.HasIndex("IdAssignedTo");

                    b.HasIndex("IdTaskType");

                    b.HasIndex("IdTeam");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("EgzaminS22323.Models.TaskType", b =>
                {
                    b.Property<int>("IdTaskType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTaskType"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTaskType");

                    b.ToTable("TaskTypes");
                });

            modelBuilder.Entity("EgzaminS22323.Models.TeamMember", b =>
                {
                    b.Property<int>("IdTeamMember")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTeamMember"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTeamMember");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("EgzaminS22323.Models.Task", b =>
                {
                    b.HasOne("EgzaminS22323.Models.TeamMember", "ICreatorNavigation")
                        .WithMany()
                        .HasForeignKey("ICreatorNavigationIdTeamMember")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EgzaminS22323.Models.TeamMember", "IAssignedToNavigation")
                        .WithMany("Tasks")
                        .HasForeignKey("IdAssignedTo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EgzaminS22323.Models.TaskType", "ITaskTypeNavigation")
                        .WithMany("Tasks")
                        .HasForeignKey("IdTaskType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EgzaminS22323.Models.Project", "IProjectNavigation")
                        .WithMany("Tasks")
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IAssignedToNavigation");

                    b.Navigation("ICreatorNavigation");

                    b.Navigation("IProjectNavigation");

                    b.Navigation("ITaskTypeNavigation");
                });

            modelBuilder.Entity("EgzaminS22323.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("EgzaminS22323.Models.TaskType", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("EgzaminS22323.Models.TeamMember", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}