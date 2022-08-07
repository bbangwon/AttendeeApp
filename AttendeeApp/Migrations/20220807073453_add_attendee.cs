using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendeeApp.Migrations
{
    public partial class add_attendee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendees");
        }
    }
}
