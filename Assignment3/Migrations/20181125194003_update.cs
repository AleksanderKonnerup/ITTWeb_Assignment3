using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategorieIds",
                table: "ComponentType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComponentIds",
                table: "ComponentType",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StaffInitials = table.Column<string>(nullable: true),
                    AUId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "UserCredentials",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Hash = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCredentials", x => x.Email);
                    table.ForeignKey(
                        name: "FK_UserCredentials_User_Email",
                        column: x => x.Email,
                        principalTable: "User",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCredentials");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropColumn(
                name: "CategorieIds",
                table: "ComponentType");

            migrationBuilder.DropColumn(
                name: "ComponentIds",
                table: "ComponentType");
        }
    }
}
