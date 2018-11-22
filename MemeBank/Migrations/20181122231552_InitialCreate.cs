using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MemeBank.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Meeting_Agenda = table.Column<string>(nullable: true),
                    Meeting_Description = table.Column<string>(nullable: true),
                    Meeting_Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemeItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Uploaded = table.Column<string>(nullable: true),
                    Width = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemeItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task_Name = table.Column<string>(nullable: true),
                    Task_Priority = table.Column<int>(nullable: false),
                    Task_Description = table.Column<string>(nullable: true),
                    Task_CourseNumber = table.Column<string>(nullable: true),
                    Task_Deadline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingItem");

            migrationBuilder.DropTable(
                name: "MemeItem");

            migrationBuilder.DropTable(
                name: "TaskItem");
        }
    }
}
