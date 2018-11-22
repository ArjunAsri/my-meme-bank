﻿// <auto-generated />
using System;
using MemeBank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MemeBank.Migrations
{
    [DbContext(typeof(MemeBankContext))]
    partial class MemeBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MemeBank.Models.MeetingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Meeting_Agenda");

                    b.Property<string>("Meeting_Description");

                    b.Property<int>("Meeting_Time");

                    b.HasKey("Id");

                    b.ToTable("MeetingItem");
                });

            modelBuilder.Entity("MemeBank.Models.MemeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Height");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<string>("Uploaded");

                    b.Property<string>("Url");

                    b.Property<string>("Width");

                    b.HasKey("Id");

                    b.ToTable("MemeItem");
                });

            modelBuilder.Entity("MemeBank.Models.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Task_CourseNumber");

                    b.Property<DateTime>("Task_Deadline");

                    b.Property<string>("Task_Description");

                    b.Property<string>("Task_Name");

                    b.Property<int>("Task_Priority");

                    b.HasKey("Id");

                    b.ToTable("TaskItem");
                });
#pragma warning restore 612, 618
        }
    }
}
