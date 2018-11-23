﻿// <auto-generated />
using System;
using MSA_Task_Schedule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSA_Task_Schedule.Migrations
{
    [DbContext(typeof(MSA_Task_ScheduleContext))]
    partial class MSA_Task_ScheduleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MSA_Task_Schedule.Models.MeetingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Meeting_Agenda");

                    b.Property<string>("Meeting_Description");

                    b.Property<int>("Meeting_Time");

                    b.HasKey("Id");

                    b.ToTable("MeetingItem");
                });

            modelBuilder.Entity("MSA_Task_Schedule.Models.TaskItem", b =>
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
