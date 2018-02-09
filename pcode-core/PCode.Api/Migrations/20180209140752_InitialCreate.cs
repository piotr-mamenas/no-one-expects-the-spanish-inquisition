using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PCode.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProfileGuid = table.Column<Guid>(nullable: true),
                    Score = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Skills_Profiles_ProfileGuid",
                        column: x => x.ProfileGuid,
                        principalTable: "Profiles",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ProfileGuid",
                table: "Skills",
                column: "ProfileGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
