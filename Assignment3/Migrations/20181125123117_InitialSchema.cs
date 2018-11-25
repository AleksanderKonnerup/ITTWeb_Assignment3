using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    ComponentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComponentTypeId = table.Column<long>(nullable: false),
                    ComponentNumber = table.Column<int>(nullable: false),
                    SerialNo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    AdminComment = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    CurrentLoanInformationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.ComponentId);
                });

            migrationBuilder.CreateTable(
                name: "ESImage",
                columns: table => new
                {
                    ESImageId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageMimeType = table.Column<string>(maxLength: 128, nullable: true),
                    Thumbnail = table.Column<byte[]>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESImage", x => x.ESImageId);
                });

            migrationBuilder.CreateTable(
                name: "ComponentType",
                columns: table => new
                {
                    ComponentTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComponentName = table.Column<string>(nullable: true),
                    ComponentInfo = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Datasheet = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    WikiLink = table.Column<string>(nullable: true),
                    AdminComment = table.Column<string>(nullable: true),
                    ImageESImageId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentType", x => x.ComponentTypeId);
                    table.ForeignKey(
                        name: "FK_ComponentType_ESImage_ImageESImageId",
                        column: x => x.ImageESImageId,
                        principalTable: "ESImage",
                        principalColumn: "ESImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentType_ImageESImageId",
                table: "ComponentType",
                column: "ImageESImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropTable(
                name: "ComponentType");

            migrationBuilder.DropTable(
                name: "ESImage");
        }
    }
}
